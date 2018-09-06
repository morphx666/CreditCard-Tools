Public Class FormMain
    Dim mCC As New CC()

    Private Sub TextBoxCCNum_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxCCNum.TextChanged
        mCC.Number = TextBoxCCNum.Text

        LabelANResult.Text = mCC.Account
        LabelIINResult.Text = mCC.IssuerIdentificationNumber.ToString().Prettify()
        LabelMIIResult.Text = mCC.MajorIndustryIdentifier.ToString().Prettify()
        LabelValidityResult.Text = mCC.IsValid.ToString()
        LabelValidityResult.ForeColor = If(mCC.IsValid, Color.Green, Color.Red)
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCCNum.Text = mCC.Number
    End Sub

    Private Sub ButtonGenerator_Click(sender As Object, e As EventArgs) Handles ButtonGenerator.Click
        Using dlg As New FormGenerator()
            dlg.ShowDialog(Me)
            If dlg.ListViewCCs.SelectedItems.Count = 1 Then TextBoxCCNum.Text = dlg.ListViewCCs.SelectedItems(0).Text.Replace(" ", "")
        End Using
    End Sub
End Class