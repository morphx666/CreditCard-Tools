<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListViewCCs = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBoxMII = New System.Windows.Forms.ComboBox()
        Me.ComboBoxIIN = New System.Windows.Forms.ComboBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelCopy2Clip = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelMMIDescription = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewCCs
        '
        Me.ListViewCCs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewCCs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNumber})
        Me.ListViewCCs.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewCCs.FullRowSelect = True
        Me.ListViewCCs.GridLines = True
        Me.ListViewCCs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewCCs.Location = New System.Drawing.Point(14, 71)
        Me.ListViewCCs.Name = "ListViewCCs"
        Me.ListViewCCs.Size = New System.Drawing.Size(459, 443)
        Me.ListViewCCs.TabIndex = 0
        Me.ListViewCCs.UseCompatibleStateImageBehavior = False
        Me.ListViewCCs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNumber
        '
        Me.ColumnHeaderNumber.Text = "Number"
        '
        'ComboBoxMII
        '
        Me.ComboBoxMII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMII.FormattingEnabled = True
        Me.ComboBoxMII.Location = New System.Drawing.Point(14, 27)
        Me.ComboBoxMII.Name = "ComboBoxMII"
        Me.ComboBoxMII.Size = New System.Drawing.Size(226, 23)
        Me.ComboBoxMII.TabIndex = 1
        '
        'ComboBoxIIN
        '
        Me.ComboBoxIIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxIIN.FormattingEnabled = True
        Me.ComboBoxIIN.Location = New System.Drawing.Point(246, 27)
        Me.ComboBoxIIN.Name = "ComboBoxIIN"
        Me.ComboBoxIIN.Size = New System.Drawing.Size(227, 23)
        Me.ComboBoxIIN.TabIndex = 1
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefresh.Location = New System.Drawing.Point(317, 520)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(14, 517)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(45, 15)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "Total: 0"
        '
        'LabelCopy2Clip
        '
        Me.LabelCopy2Clip.AutoSize = True
        Me.LabelCopy2Clip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopy2Clip.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelCopy2Clip.Location = New System.Drawing.Point(164, 53)
        Me.LabelCopy2Clip.Name = "LabelCopy2Clip"
        Me.LabelCopy2Clip.Padding = New System.Windows.Forms.Padding(6)
        Me.LabelCopy2Clip.Size = New System.Drawing.Size(142, 29)
        Me.LabelCopy2Clip.TabIndex = 4
        Me.LabelCopy2Clip.Text = "Copied to clipboard"
        Me.LabelCopy2Clip.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Major Industry Identifier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Issuer Identification"
        '
        'LabelMMIDescription
        '
        Me.LabelMMIDescription.AutoSize = True
        Me.LabelMMIDescription.Location = New System.Drawing.Point(14, 53)
        Me.LabelMMIDescription.Name = "LabelMMIDescription"
        Me.LabelMMIDescription.Size = New System.Drawing.Size(0, 15)
        Me.LabelMMIDescription.TabIndex = 6
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(398, 520)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelMMIDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCopy2Clip)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ComboBoxIIN)
        Me.Controls.Add(Me.ComboBoxMII)
        Me.Controls.Add(Me.ListViewCCs)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(505, 9999)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(505, 594)
        Me.Name = "FormGenerator"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewCCs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBoxMII As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxIIN As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents LabelCopy2Clip As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelMMIDescription As Label
    Friend WithEvents ButtonClose As Button
End Class
