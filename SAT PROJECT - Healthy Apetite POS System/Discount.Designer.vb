<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discount
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
        Me.radExactDiscount = New System.Windows.Forms.RadioButton()
        Me.radPercentageDiscount = New System.Windows.Forms.RadioButton()
        Me.txtOffFinalPrice = New System.Windows.Forms.TextBox()
        Me.txtPercentOff = New System.Windows.Forms.TextBox()
        Me.lblPercentOff = New System.Windows.Forms.Label()
        Me.lblOffFinalPrice = New System.Windows.Forms.Label()
        Me.btnExitDiscount = New System.Windows.Forms.Button()
        Me.cmdApplyDiscount = New System.Windows.Forms.Button()
        Me.lblTitleDiscount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radExactDiscount
        '
        Me.radExactDiscount.AutoSize = True
        Me.radExactDiscount.Location = New System.Drawing.Point(164, 131)
        Me.radExactDiscount.Name = "radExactDiscount"
        Me.radExactDiscount.Size = New System.Drawing.Size(141, 24)
        Me.radExactDiscount.TabIndex = 0
        Me.radExactDiscount.TabStop = True
        Me.radExactDiscount.Text = "Exact Discount"
        Me.radExactDiscount.UseVisualStyleBackColor = True
        '
        'radPercentageDiscount
        '
        Me.radPercentageDiscount.AutoSize = True
        Me.radPercentageDiscount.Location = New System.Drawing.Point(164, 194)
        Me.radPercentageDiscount.Name = "radPercentageDiscount"
        Me.radPercentageDiscount.Size = New System.Drawing.Size(183, 24)
        Me.radPercentageDiscount.TabIndex = 1
        Me.radPercentageDiscount.TabStop = True
        Me.radPercentageDiscount.Text = "Percentage Discount"
        Me.radPercentageDiscount.UseVisualStyleBackColor = True
        '
        'txtOffFinalPrice
        '
        Me.txtOffFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffFinalPrice.Location = New System.Drawing.Point(353, 191)
        Me.txtOffFinalPrice.Name = "txtOffFinalPrice"
        Me.txtOffFinalPrice.Size = New System.Drawing.Size(289, 30)
        Me.txtOffFinalPrice.TabIndex = 2
        '
        'txtPercentOff
        '
        Me.txtPercentOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPercentOff.Location = New System.Drawing.Point(353, 129)
        Me.txtPercentOff.Name = "txtPercentOff"
        Me.txtPercentOff.Size = New System.Drawing.Size(289, 30)
        Me.txtPercentOff.TabIndex = 3
        '
        'lblPercentOff
        '
        Me.lblPercentOff.AutoSize = True
        Me.lblPercentOff.Location = New System.Drawing.Point(648, 135)
        Me.lblPercentOff.Name = "lblPercentOff"
        Me.lblPercentOff.Size = New System.Drawing.Size(49, 20)
        Me.lblPercentOff.TabIndex = 4
        Me.lblPercentOff.Text = "% Off"
        '
        'lblOffFinalPrice
        '
        Me.lblOffFinalPrice.AutoSize = True
        Me.lblOffFinalPrice.Location = New System.Drawing.Point(648, 198)
        Me.lblOffFinalPrice.Name = "lblOffFinalPrice"
        Me.lblOffFinalPrice.Size = New System.Drawing.Size(108, 20)
        Me.lblOffFinalPrice.TabIndex = 5
        Me.lblOffFinalPrice.Text = "Off Final Price"
        '
        'btnExitDiscount
        '
        Me.btnExitDiscount.Location = New System.Drawing.Point(12, 12)
        Me.btnExitDiscount.Name = "btnExitDiscount"
        Me.btnExitDiscount.Size = New System.Drawing.Size(190, 75)
        Me.btnExitDiscount.TabIndex = 6
        Me.btnExitDiscount.Text = "Go Back"
        Me.btnExitDiscount.UseVisualStyleBackColor = True
        '
        'cmdApplyDiscount
        '
        Me.cmdApplyDiscount.Location = New System.Drawing.Point(353, 284)
        Me.cmdApplyDiscount.Name = "cmdApplyDiscount"
        Me.cmdApplyDiscount.Size = New System.Drawing.Size(289, 64)
        Me.cmdApplyDiscount.TabIndex = 7
        Me.cmdApplyDiscount.Text = "Apply Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdApplyDiscount.UseVisualStyleBackColor = True
        '
        'lblTitleDiscount
        '
        Me.lblTitleDiscount.AutoSize = True
        Me.lblTitleDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDiscount.Location = New System.Drawing.Point(226, 28)
        Me.lblTitleDiscount.Name = "lblTitleDiscount"
        Me.lblTitleDiscount.Size = New System.Drawing.Size(346, 46)
        Me.lblTitleDiscount.TabIndex = 8
        Me.lblTitleDiscount.Text = "Discount Window"
        '
        'Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitleDiscount)
        Me.Controls.Add(Me.cmdApplyDiscount)
        Me.Controls.Add(Me.btnExitDiscount)
        Me.Controls.Add(Me.lblOffFinalPrice)
        Me.Controls.Add(Me.lblPercentOff)
        Me.Controls.Add(Me.txtPercentOff)
        Me.Controls.Add(Me.txtOffFinalPrice)
        Me.Controls.Add(Me.radPercentageDiscount)
        Me.Controls.Add(Me.radExactDiscount)
        Me.Name = "Discount"
        Me.Text = "Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radExactDiscount As RadioButton
    Friend WithEvents radPercentageDiscount As RadioButton
    Friend WithEvents txtOffFinalPrice As TextBox
    Friend WithEvents txtPercentOff As TextBox
    Friend WithEvents lblPercentOff As Label
    Friend WithEvents lblOffFinalPrice As Label
    Friend WithEvents btnExitDiscount As Button
    Friend WithEvents cmdApplyDiscount As Button
    Friend WithEvents lblTitleDiscount As Label
End Class
