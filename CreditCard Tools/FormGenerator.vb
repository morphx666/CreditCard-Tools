Imports CreditCard_Tools.CC

Public Class FormGenerator
    Private Sub FormGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ComboBoxMII.SelectedIndexChanged, Sub() UpdateMII()
        AddHandler ComboBoxIIN.SelectedIndexChanged, Sub() Generate()

        For Each mii In [Enum].GetNames(GetType(CC.MajorIndustryIdentifiers))
            ComboBoxMII.Items.Add(mii)
        Next
        ComboBoxMII.SelectedIndex = 4

        'For Each iin In [Enum].GetNames(GetType(CC.IssuerIdentificationNumbers))
        '    ComboBoxIIN.Items.Add(iin)
        'Next
        'ComboBoxIIN.SelectedIndex = 16
    End Sub

    Private Sub UpdateMII()
        Dim mii As CC.MajorIndustryIdentifiers = [Enum].Parse(GetType(CC.MajorIndustryIdentifiers), ComboBoxMII.SelectedItem.ToString())
        LabelMMIDescription.Text = Description.GetDescription(mii)

        ComboBoxIIN.Items.Clear()
        ComboBoxIIN.Items.Add(IssuerIdentificationNumbers.Invalid)

        Dim ev2 As IssuerIdentificationNumbers

        For Each iin In [Enum].GetNames(GetType(CC.IssuerIdentificationNumbers))
            If [Enum].TryParse(iin, ev2) Then
                For Each r In Range.GetRanges(ev2)
                    If Not ComboBoxIIN.Items.Contains(ev2) Then
                        For Each miir In Range.GetRanges(mii)

                            Dim rsMin As Boolean = Integer.Parse(r.Min.ToString().Substring(0, miir.Min.ToString().Length)) >= miir.Min
                            Dim rsMax As Boolean = Integer.Parse(r.Max.ToString().Substring(0, miir.Max.ToString().Length)) <= miir.Max

                            If rsMin AndAlso rsMax Then
                                ComboBoxIIN.Items.Add(ev2)
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If
        Next

        ComboBoxIIN.SelectedIndex = If(ComboBoxIIN.Items.Count = 1, 0, 1)
    End Sub

    Private Sub Generate()
        Dim mii As CC.MajorIndustryIdentifiers = [Enum].Parse(GetType(CC.MajorIndustryIdentifiers), ComboBoxMII.SelectedItem.ToString())
        Dim iin As CC.IssuerIdentificationNumbers = [Enum].Parse(GetType(CC.IssuerIdentificationNumbers), ComboBoxIIN.SelectedItem.ToString())

        ListViewCCs.Items.Clear()
        LabelTotal.Text = "Total: 0"
        If mii = CC.MajorIndustryIdentifiers.Invalid OrElse iin = CC.IssuerIdentificationNumbers.Invalid Then Exit Sub

        Dim ns As New List(Of String)
        Dim tries As Integer
        Dim tcc As CC

        Do
            tcc = (New CC()).Encode(mii, iin)
            If tcc IsNot Nothing AndAlso Not ns.Contains(tcc.Number) Then
                ns.Add(tcc.Number)
                tries = 0
            Else
                tries += 1
            End If
        Loop Until ns.Count = 100 OrElse tries > 200

        For Each ccn In ns.OrderBy(Function(n) n)
            Dim s As String = ""
            For i As Integer = 0 To 4 - 1
                s += ccn.Substring(i * 4, 4) + " "
            Next
            ListViewCCs.Items.Add(s.Trim())
        Next

        ListViewCCs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        LabelTotal.Text = "Total: " + ns.Count.ToString()

        ListViewCCs.Enabled = ns.Any()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Generate()
    End Sub

    Private Sub ListViewCCs_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListViewCCs.MouseDoubleClick
        If ListViewCCs.SelectedItems.Count = 1 Then

            Dim p As Point = e.Location
            p.Offset(ListViewCCs.Location)
            p.Offset(20, 0)
            With LabelCopy2Clip
                .Location = p
                .Visible = True
            End With

            Clipboard.SetText(ListViewCCs.SelectedItems(0).Text.Replace(" ", ""))

            Dim tmr As New Threading.Timer(New Threading.TimerCallback(Sub()
                                                                           Me.Invoke(New MethodInvoker(Sub() LabelCopy2Clip.Visible = False))
                                                                       End Sub),
                                           Nothing,
                                           1000,
                                           Threading.Timeout.Infinite)
        End If
    End Sub
End Class