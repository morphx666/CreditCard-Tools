﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.TextBoxCCNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMII = New System.Windows.Forms.Label()
        Me.LabelIIN = New System.Windows.Forms.Label()
        Me.LabelAN = New System.Windows.Forms.Label()
        Me.LabelMIIResult = New System.Windows.Forms.Label()
        Me.LabelIINResult = New System.Windows.Forms.Label()
        Me.LabelANResult = New System.Windows.Forms.Label()
        Me.LabelValidity = New System.Windows.Forms.Label()
        Me.LabelValidityResult = New System.Windows.Forms.Label()
        Me.ButtonGenerator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxCCNum
        '
        Me.TextBoxCCNum.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCCNum.Location = New System.Drawing.Point(14, 29)
        Me.TextBoxCCNum.Name = "TextBoxCCNum"
        Me.TextBoxCCNum.Size = New System.Drawing.Size(150, 26)
        Me.TextBoxCCNum.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Credit Card Number"
        Me.Label1.UseMnemonic = False
        '
        'LabelMII
        '
        Me.LabelMII.AutoSize = True
        Me.LabelMII.Location = New System.Drawing.Point(14, 78)
        Me.LabelMII.Name = "LabelMII"
        Me.LabelMII.Size = New System.Drawing.Size(137, 15)
        Me.LabelMII.TabIndex = 2
        Me.LabelMII.Text = "Major Industry Identifier:"
        Me.LabelMII.UseMnemonic = False
        '
        'LabelIIN
        '
        Me.LabelIIN.AutoSize = True
        Me.LabelIIN.Location = New System.Drawing.Point(14, 104)
        Me.LabelIIN.Name = "LabelIIN"
        Me.LabelIIN.Size = New System.Drawing.Size(160, 15)
        Me.LabelIIN.TabIndex = 2
        Me.LabelIIN.Text = "Issuer Identification Number:"
        Me.LabelIIN.UseMnemonic = False
        '
        'LabelAN
        '
        Me.LabelAN.AutoSize = True
        Me.LabelAN.Location = New System.Drawing.Point(14, 129)
        Me.LabelAN.Name = "LabelAN"
        Me.LabelAN.Size = New System.Drawing.Size(102, 15)
        Me.LabelAN.TabIndex = 2
        Me.LabelAN.Text = "Account Number:"
        Me.LabelAN.UseMnemonic = False
        '
        'LabelMIIResult
        '
        Me.LabelMIIResult.AutoSize = True
        Me.LabelMIIResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMIIResult.Location = New System.Drawing.Point(229, 76)
        Me.LabelMIIResult.Name = "LabelMIIResult"
        Me.LabelMIIResult.Size = New System.Drawing.Size(30, 16)
        Me.LabelMIIResult.TabIndex = 3
        Me.LabelMIIResult.Text = "n/a"
        Me.LabelMIIResult.UseMnemonic = False
        '
        'LabelIINResult
        '
        Me.LabelIINResult.AutoSize = True
        Me.LabelIINResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIINResult.Location = New System.Drawing.Point(229, 102)
        Me.LabelIINResult.Name = "LabelIINResult"
        Me.LabelIINResult.Size = New System.Drawing.Size(30, 16)
        Me.LabelIINResult.TabIndex = 3
        Me.LabelIINResult.Text = "n/a"
        Me.LabelIINResult.UseMnemonic = False
        '
        'LabelANResult
        '
        Me.LabelANResult.AutoSize = True
        Me.LabelANResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelANResult.Location = New System.Drawing.Point(229, 127)
        Me.LabelANResult.Name = "LabelANResult"
        Me.LabelANResult.Size = New System.Drawing.Size(30, 16)
        Me.LabelANResult.TabIndex = 3
        Me.LabelANResult.Text = "n/a"
        Me.LabelANResult.UseMnemonic = False
        '
        'LabelValidity
        '
        Me.LabelValidity.AutoSize = True
        Me.LabelValidity.Location = New System.Drawing.Point(14, 163)
        Me.LabelValidity.Name = "LabelValidity"
        Me.LabelValidity.Size = New System.Drawing.Size(46, 15)
        Me.LabelValidity.TabIndex = 4
        Me.LabelValidity.Text = "Is Valid:"
        '
        'LabelValidityResult
        '
        Me.LabelValidityResult.AutoSize = True
        Me.LabelValidityResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValidityResult.Location = New System.Drawing.Point(229, 160)
        Me.LabelValidityResult.Name = "LabelValidityResult"
        Me.LabelValidityResult.Size = New System.Drawing.Size(30, 16)
        Me.LabelValidityResult.TabIndex = 3
        Me.LabelValidityResult.Text = "n/a"
        Me.LabelValidityResult.UseMnemonic = False
        '
        'ButtonGenerator
        '
        Me.ButtonGenerator.Location = New System.Drawing.Point(383, 216)
        Me.ButtonGenerator.Name = "ButtonGenerator"
        Me.ButtonGenerator.Size = New System.Drawing.Size(87, 27)
        Me.ButtonGenerator.TabIndex = 5
        Me.ButtonGenerator.Text = "Generator"
        Me.ButtonGenerator.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 256)
        Me.Controls.Add(Me.ButtonGenerator)
        Me.Controls.Add(Me.LabelValidity)
        Me.Controls.Add(Me.LabelValidityResult)
        Me.Controls.Add(Me.LabelANResult)
        Me.Controls.Add(Me.LabelIINResult)
        Me.Controls.Add(Me.LabelMIIResult)
        Me.Controls.Add(Me.LabelAN)
        Me.Controls.Add(Me.LabelIIN)
        Me.Controls.Add(Me.LabelMII)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCCNum)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreditCard Tools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCCNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelMII As System.Windows.Forms.Label
    Friend WithEvents LabelIIN As System.Windows.Forms.Label
    Friend WithEvents LabelAN As System.Windows.Forms.Label
    Friend WithEvents LabelMIIResult As System.Windows.Forms.Label
    Friend WithEvents LabelIINResult As System.Windows.Forms.Label
    Friend WithEvents LabelANResult As System.Windows.Forms.Label
    Friend WithEvents LabelValidity As System.Windows.Forms.Label
    Friend WithEvents LabelValidityResult As System.Windows.Forms.Label
    Friend WithEvents ButtonGenerator As System.Windows.Forms.Button

End Class
