<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Discount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.radExactDiscount = New System.Windows.Forms.RadioButton()
        Me.radPercentageDiscount = New System.Windows.Forms.RadioButton()
        Me.txtOffFinalPrice = New System.Windows.Forms.TextBox()
        Me.txtPercentOff = New System.Windows.Forms.TextBox()
        Me.lblPercentOff = New System.Windows.Forms.Label()
        Me.lblOffFinalPrice = New System.Windows.Forms.Label()
        Me.cmdApplyDiscount = New System.Windows.Forms.Button()
        Me.lblTitleDiscount = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmbxItemSelect = New System.Windows.Forms.ComboBox()
        Me.chkSpecificItemToggle = New System.Windows.Forms.CheckBox()
        Me.lblDiscountInstruction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radExactDiscount
        '
        Me.radExactDiscount.AutoSize = True
        Me.radExactDiscount.Location = New System.Drawing.Point(51, 205)
        Me.radExactDiscount.Name = "radExactDiscount"
        Me.radExactDiscount.Size = New System.Drawing.Size(141, 24)
        Me.radExactDiscount.TabIndex = 0
        Me.radExactDiscount.Text = "Exact Discount"
        Me.radExactDiscount.UseVisualStyleBackColor = True
        '
        'radPercentageDiscount
        '
        Me.radPercentageDiscount.AutoSize = True
        Me.radPercentageDiscount.Location = New System.Drawing.Point(9, 143)
        Me.radPercentageDiscount.Name = "radPercentageDiscount"
        Me.radPercentageDiscount.Size = New System.Drawing.Size(183, 24)
        Me.radPercentageDiscount.TabIndex = 1
        Me.radPercentageDiscount.Text = "Percentage Discount"
        Me.radPercentageDiscount.UseVisualStyleBackColor = True
        '
        'txtOffFinalPrice
        '
        Me.txtOffFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffFinalPrice.Location = New System.Drawing.Point(222, 205)
        Me.txtOffFinalPrice.Name = "txtOffFinalPrice"
        Me.txtOffFinalPrice.Size = New System.Drawing.Size(289, 30)
        Me.txtOffFinalPrice.TabIndex = 2
        '
        'txtPercentOff
        '
        Me.txtPercentOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPercentOff.Location = New System.Drawing.Point(222, 143)
        Me.txtPercentOff.Name = "txtPercentOff"
        Me.txtPercentOff.Size = New System.Drawing.Size(289, 30)
        Me.txtPercentOff.TabIndex = 3
        '
        'lblPercentOff
        '
        Me.lblPercentOff.AutoSize = True
        Me.lblPercentOff.Location = New System.Drawing.Point(518, 149)
        Me.lblPercentOff.Name = "lblPercentOff"
        Me.lblPercentOff.Size = New System.Drawing.Size(49, 20)
        Me.lblPercentOff.TabIndex = 4
        Me.lblPercentOff.Text = "% Off"
        '
        'lblOffFinalPrice
        '
        Me.lblOffFinalPrice.AutoSize = True
        Me.lblOffFinalPrice.Location = New System.Drawing.Point(518, 212)
        Me.lblOffFinalPrice.Name = "lblOffFinalPrice"
        Me.lblOffFinalPrice.Size = New System.Drawing.Size(108, 20)
        Me.lblOffFinalPrice.TabIndex = 5
        Me.lblOffFinalPrice.Text = "Off Final Price"
        '
        'cmdApplyDiscount
        '
        Me.cmdApplyDiscount.Location = New System.Drawing.Point(224, 368)
        Me.cmdApplyDiscount.Name = "cmdApplyDiscount"
        Me.cmdApplyDiscount.Size = New System.Drawing.Size(290, 65)
        Me.cmdApplyDiscount.TabIndex = 7
        Me.cmdApplyDiscount.Text = "Apply Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdApplyDiscount.UseVisualStyleBackColor = True
        '
        'lblTitleDiscount
        '
        Me.lblTitleDiscount.AutoSize = True
        Me.lblTitleDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDiscount.Location = New System.Drawing.Point(213, 32)
        Me.lblTitleDiscount.Name = "lblTitleDiscount"
        Me.lblTitleDiscount.Size = New System.Drawing.Size(346, 46)
        Me.lblTitleDiscount.TabIndex = 8
        Me.lblTitleDiscount.Text = "Discount Window"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.IndianRed
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(16, 17)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(190, 92)
        Me.cmdExit.TabIndex = 41
        Me.cmdExit.Text = "EXIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmbxItemSelect
        '
        Me.cmbxItemSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbxItemSelect.FormattingEnabled = True
        Me.cmbxItemSelect.Location = New System.Drawing.Point(224, 268)
        Me.cmbxItemSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxItemSelect.Name = "cmbxItemSelect"
        Me.cmbxItemSelect.Size = New System.Drawing.Size(288, 33)
        Me.cmbxItemSelect.TabIndex = 42
        '
        'chkSpecificItemToggle
        '
        Me.chkSpecificItemToggle.AutoSize = True
        Me.chkSpecificItemToggle.Checked = True
        Me.chkSpecificItemToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSpecificItemToggle.Location = New System.Drawing.Point(33, 263)
        Me.chkSpecificItemToggle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSpecificItemToggle.Name = "chkSpecificItemToggle"
        Me.chkSpecificItemToggle.Size = New System.Drawing.Size(159, 44)
        Me.chkSpecificItemToggle.TabIndex = 44
        Me.chkSpecificItemToggle.Text = "Apply Discount to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "specific item" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkSpecificItemToggle.UseVisualStyleBackColor = True
        '
        'lblDiscountInstruction
        '
        Me.lblDiscountInstruction.AutoSize = True
        Me.lblDiscountInstruction.Location = New System.Drawing.Point(522, 263)
        Me.lblDiscountInstruction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscountInstruction.Name = "lblDiscountInstruction"
        Me.lblDiscountInstruction.Size = New System.Drawing.Size(127, 60)
        Me.lblDiscountInstruction.TabIndex = 46
        Me.lblDiscountInstruction.Text = "Select item from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drop Down box" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to be discounted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 449)
        Me.Controls.Add(Me.lblDiscountInstruction)
        Me.Controls.Add(Me.chkSpecificItemToggle)
        Me.Controls.Add(Me.cmbxItemSelect)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblTitleDiscount)
        Me.Controls.Add(Me.cmdApplyDiscount)
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
    Friend WithEvents cmdApplyDiscount As Button
    Friend WithEvents lblTitleDiscount As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmbxItemSelect As ComboBox
    Friend WithEvents chkSpecificItemToggle As CheckBox
    Friend WithEvents lblDiscountInstruction As Label
End Class
