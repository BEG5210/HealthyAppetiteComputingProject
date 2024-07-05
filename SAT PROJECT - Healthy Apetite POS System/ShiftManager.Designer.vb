<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftManager
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBeginShift = New System.Windows.Forms.TabPage()
        Me.tabEndShift = New System.Windows.Forms.TabPage()
        Me.lblLiveDateandTime = New System.Windows.Forms.Label()
        Me.lblNameBeginShift = New System.Windows.Forms.Label()
        Me.lblNameEndShift = New System.Windows.Forms.Label()
        Me.txtNameEndShift = New System.Windows.Forms.TextBox()
        Me.cmbNameEndShift = New System.Windows.Forms.ComboBox()
        Me.cmdBeginShift = New System.Windows.Forms.Button()
        Me.cmdEndShift = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtDuty = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabBeginShift.SuspendLayout()
        Me.tabEndShift.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBeginShift)
        Me.TabControl1.Controls.Add(Me.tabEndShift)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(295, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(734, 530)
        Me.TabControl1.TabIndex = 0
        '
        'tabBeginShift
        '
        Me.tabBeginShift.Controls.Add(Me.cmdBeginShift)
        Me.tabBeginShift.Controls.Add(Me.txtNameEndShift)
        Me.tabBeginShift.Controls.Add(Me.lblNameBeginShift)
        Me.tabBeginShift.Location = New System.Drawing.Point(4, 45)
        Me.tabBeginShift.Name = "tabBeginShift"
        Me.tabBeginShift.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBeginShift.Size = New System.Drawing.Size(726, 481)
        Me.tabBeginShift.TabIndex = 2
        Me.tabBeginShift.Text = "Begin Shift"
        Me.tabBeginShift.UseVisualStyleBackColor = True
        '
        'tabEndShift
        '
        Me.tabEndShift.Controls.Add(Me.cmdEndShift)
        Me.tabEndShift.Controls.Add(Me.cmbNameEndShift)
        Me.tabEndShift.Controls.Add(Me.lblNameEndShift)
        Me.tabEndShift.Location = New System.Drawing.Point(4, 45)
        Me.tabEndShift.Name = "tabEndShift"
        Me.tabEndShift.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEndShift.Size = New System.Drawing.Size(726, 481)
        Me.tabEndShift.TabIndex = 3
        Me.tabEndShift.Text = "End Shift"
        Me.tabEndShift.UseVisualStyleBackColor = True
        '
        'lblLiveDateandTime
        '
        Me.lblLiveDateandTime.AutoSize = True
        Me.lblLiveDateandTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLiveDateandTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiveDateandTime.Location = New System.Drawing.Point(295, 9)
        Me.lblLiveDateandTime.Name = "lblLiveDateandTime"
        Me.lblLiveDateandTime.Size = New System.Drawing.Size(358, 57)
        Me.lblLiveDateandTime.TabIndex = 1
        Me.lblLiveDateandTime.Text = "*DateAndTime*"
        '
        'lblNameBeginShift
        '
        Me.lblNameBeginShift.AutoSize = True
        Me.lblNameBeginShift.Location = New System.Drawing.Point(106, 149)
        Me.lblNameBeginShift.Name = "lblNameBeginShift"
        Me.lblNameBeginShift.Size = New System.Drawing.Size(99, 36)
        Me.lblNameBeginShift.TabIndex = 2
        Me.lblNameBeginShift.Text = "Name"
        '
        'lblNameEndShift
        '
        Me.lblNameEndShift.AutoSize = True
        Me.lblNameEndShift.Location = New System.Drawing.Point(106, 149)
        Me.lblNameEndShift.Name = "lblNameEndShift"
        Me.lblNameEndShift.Size = New System.Drawing.Size(99, 36)
        Me.lblNameEndShift.TabIndex = 3
        Me.lblNameEndShift.Text = "Name"
        '
        'txtNameEndShift
        '
        Me.txtNameEndShift.Location = New System.Drawing.Point(211, 141)
        Me.txtNameEndShift.Name = "txtNameEndShift"
        Me.txtNameEndShift.Size = New System.Drawing.Size(369, 44)
        Me.txtNameEndShift.TabIndex = 3
        '
        'cmbNameEndShift
        '
        Me.cmbNameEndShift.FormattingEnabled = True
        Me.cmbNameEndShift.Location = New System.Drawing.Point(211, 141)
        Me.cmbNameEndShift.Name = "cmbNameEndShift"
        Me.cmbNameEndShift.Size = New System.Drawing.Size(368, 44)
        Me.cmbNameEndShift.TabIndex = 4
        '
        'cmdBeginShift
        '
        Me.cmdBeginShift.Location = New System.Drawing.Point(206, 259)
        Me.cmdBeginShift.Name = "cmdBeginShift"
        Me.cmdBeginShift.Size = New System.Drawing.Size(373, 128)
        Me.cmdBeginShift.TabIndex = 4
        Me.cmdBeginShift.Text = "BEGIN SHIFT"
        Me.cmdBeginShift.UseVisualStyleBackColor = True
        '
        'cmdEndShift
        '
        Me.cmdEndShift.Location = New System.Drawing.Point(206, 259)
        Me.cmdEndShift.Name = "cmdEndShift"
        Me.cmdEndShift.Size = New System.Drawing.Size(373, 128)
        Me.cmdEndShift.TabIndex = 5
        Me.cmdEndShift.Text = "END SHIFT"
        Me.cmdEndShift.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(12, 9)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(266, 110)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtDuty
        '
        Me.txtDuty.Location = New System.Drawing.Point(13, 125)
        Me.txtDuty.Multiline = True
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.Size = New System.Drawing.Size(265, 481)
        Me.txtDuty.TabIndex = 3
        Me.txtDuty.Text = "*Maybe there could be a list of the current people on duty?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(so one may know if " &
    "they have made a mistake in the event that they forgot to end the shift or that " &
    "they forgot to start it)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ShiftManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 621)
        Me.Controls.Add(Me.txtDuty)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblLiveDateandTime)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ShiftManager"
        Me.Text = "ShiftManager"
        Me.TabControl1.ResumeLayout(False)
        Me.tabBeginShift.ResumeLayout(False)
        Me.tabBeginShift.PerformLayout()
        Me.tabEndShift.ResumeLayout(False)
        Me.tabEndShift.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabBeginShift As TabPage
    Friend WithEvents tabEndShift As TabPage
    Friend WithEvents lblLiveDateandTime As Label
    Friend WithEvents lblNameBeginShift As Label
    Friend WithEvents txtNameEndShift As TextBox
    Friend WithEvents cmbNameEndShift As ComboBox
    Friend WithEvents lblNameEndShift As Label
    Friend WithEvents cmdBeginShift As Button
    Friend WithEvents cmdEndShift As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents txtDuty As TextBox
End Class
