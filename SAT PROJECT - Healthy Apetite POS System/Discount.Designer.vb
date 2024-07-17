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
        Me.cmdApplyDiscount = New System.Windows.Forms.Button()
        Me.lblTitleDiscount = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radExactDiscount
        '
        Me.radExactDiscount.AutoSize = True
        Me.radExactDiscount.Location = New System.Drawing.Point(109, 85)
        Me.radExactDiscount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radExactDiscount.Name = "radExactDiscount"
        Me.radExactDiscount.Size = New System.Drawing.Size(97, 17)
        Me.radExactDiscount.TabIndex = 0
        Me.radExactDiscount.TabStop = True
        Me.radExactDiscount.Text = "Exact Discount"
        Me.radExactDiscount.UseVisualStyleBackColor = True
        '
        'radPercentageDiscount
        '
        Me.radPercentageDiscount.AutoSize = True
        Me.radPercentageDiscount.Location = New System.Drawing.Point(109, 126)
        Me.radPercentageDiscount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radPercentageDiscount.Name = "radPercentageDiscount"
        Me.radPercentageDiscount.Size = New System.Drawing.Size(125, 17)
        Me.radPercentageDiscount.TabIndex = 1
        Me.radPercentageDiscount.TabStop = True
        Me.radPercentageDiscount.Text = "Percentage Discount"
        Me.radPercentageDiscount.UseVisualStyleBackColor = True
        '
        'txtOffFinalPrice
        '
        Me.txtOffFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffFinalPrice.Location = New System.Drawing.Point(235, 124)
        Me.txtOffFinalPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOffFinalPrice.Name = "txtOffFinalPrice"
        Me.txtOffFinalPrice.Size = New System.Drawing.Size(194, 23)
        Me.txtOffFinalPrice.TabIndex = 2
        '
        'txtPercentOff
        '
        Me.txtPercentOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPercentOff.Location = New System.Drawing.Point(235, 84)
        Me.txtPercentOff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPercentOff.Name = "txtPercentOff"
        Me.txtPercentOff.Size = New System.Drawing.Size(194, 23)
        Me.txtPercentOff.TabIndex = 3
        '
        'lblPercentOff
        '
        Me.lblPercentOff.AutoSize = True
        Me.lblPercentOff.Location = New System.Drawing.Point(432, 88)
        Me.lblPercentOff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercentOff.Name = "lblPercentOff"
        Me.lblPercentOff.Size = New System.Drawing.Size(32, 13)
        Me.lblPercentOff.TabIndex = 4
        Me.lblPercentOff.Text = "% Off"
        '
        'lblOffFinalPrice
        '
        Me.lblOffFinalPrice.AutoSize = True
        Me.lblOffFinalPrice.Location = New System.Drawing.Point(432, 129)
        Me.lblOffFinalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOffFinalPrice.Name = "lblOffFinalPrice"
        Me.lblOffFinalPrice.Size = New System.Drawing.Size(73, 13)
        Me.lblOffFinalPrice.TabIndex = 5
        Me.lblOffFinalPrice.Text = "Off Final Price"
        '
        'cmdApplyDiscount
        '
        Me.cmdApplyDiscount.Location = New System.Drawing.Point(235, 185)
        Me.cmdApplyDiscount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdApplyDiscount.Name = "cmdApplyDiscount"
        Me.cmdApplyDiscount.Size = New System.Drawing.Size(193, 42)
        Me.cmdApplyDiscount.TabIndex = 7
        Me.cmdApplyDiscount.Text = "Apply Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdApplyDiscount.UseVisualStyleBackColor = True
        '
        'lblTitleDiscount
        '
        Me.lblTitleDiscount.AutoSize = True
        Me.lblTitleDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDiscount.Location = New System.Drawing.Point(151, 18)
        Me.lblTitleDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleDiscount.Name = "lblTitleDiscount"
        Me.lblTitleDiscount.Size = New System.Drawing.Size(239, 31)
        Me.lblTitleDiscount.TabIndex = 8
        Me.lblTitleDiscount.Text = "Discount Window"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.IndianRed
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(11, 11)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(127, 60)
        Me.cmdExit.TabIndex = 41
        Me.cmdExit.Text = "EXIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblTitleDiscount)
        Me.Controls.Add(Me.cmdApplyDiscount)
        Me.Controls.Add(Me.lblOffFinalPrice)
        Me.Controls.Add(Me.lblPercentOff)
        Me.Controls.Add(Me.txtPercentOff)
        Me.Controls.Add(Me.txtOffFinalPrice)
        Me.Controls.Add(Me.radPercentageDiscount)
        Me.Controls.Add(Me.radExactDiscount)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
