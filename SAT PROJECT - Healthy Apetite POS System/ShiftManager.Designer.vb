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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBeginShift = New System.Windows.Forms.TabPage()
        Me.cmdBeginShift = New System.Windows.Forms.Button()
        Me.txtNameEndShift = New System.Windows.Forms.TextBox()
        Me.lblNameBeginShift = New System.Windows.Forms.Label()
        Me.tabEndShift = New System.Windows.Forms.TabPage()
        Me.cmdEndShift = New System.Windows.Forms.Button()
        Me.cmbNameEndShift = New System.Windows.Forms.ComboBox()
        Me.lblNameEndShift = New System.Windows.Forms.Label()
        Me.lblLiveTime = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblLiveDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 94)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1017, 512)
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
        Me.tabBeginShift.Size = New System.Drawing.Size(1009, 463)
        Me.tabBeginShift.TabIndex = 2
        Me.tabBeginShift.Text = "Begin Shift"
        Me.tabBeginShift.UseVisualStyleBackColor = True
        '
        'cmdBeginShift
        '
        Me.cmdBeginShift.Location = New System.Drawing.Point(354, 220)
        Me.cmdBeginShift.Name = "cmdBeginShift"
        Me.cmdBeginShift.Size = New System.Drawing.Size(373, 128)
        Me.cmdBeginShift.TabIndex = 4
        Me.cmdBeginShift.Text = "BEGIN SHIFT"
        Me.cmdBeginShift.UseVisualStyleBackColor = True
        '
        'txtNameEndShift
        '
        Me.txtNameEndShift.Location = New System.Drawing.Point(211, 111)
        Me.txtNameEndShift.Name = "txtNameEndShift"
        Me.txtNameEndShift.Size = New System.Drawing.Size(639, 44)
        Me.txtNameEndShift.TabIndex = 3
        '
        'lblNameBeginShift
        '
        Me.lblNameBeginShift.AutoSize = True
        Me.lblNameBeginShift.Location = New System.Drawing.Point(106, 119)
        Me.lblNameBeginShift.Name = "lblNameBeginShift"
        Me.lblNameBeginShift.Size = New System.Drawing.Size(99, 36)
        Me.lblNameBeginShift.TabIndex = 2
        Me.lblNameBeginShift.Text = "Name"
        '
        'tabEndShift
        '
        Me.tabEndShift.Controls.Add(Me.cmdEndShift)
        Me.tabEndShift.Controls.Add(Me.cmbNameEndShift)
        Me.tabEndShift.Controls.Add(Me.lblNameEndShift)
        Me.tabEndShift.Location = New System.Drawing.Point(4, 45)
        Me.tabEndShift.Name = "tabEndShift"
        Me.tabEndShift.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEndShift.Size = New System.Drawing.Size(1009, 463)
        Me.tabEndShift.TabIndex = 3
        Me.tabEndShift.Text = "End Shift"
        Me.tabEndShift.UseVisualStyleBackColor = True
        '
        'cmdEndShift
        '
        Me.cmdEndShift.Location = New System.Drawing.Point(354, 220)
        Me.cmdEndShift.Name = "cmdEndShift"
        Me.cmdEndShift.Size = New System.Drawing.Size(373, 128)
        Me.cmdEndShift.TabIndex = 5
        Me.cmdEndShift.Text = "END SHIFT"
        Me.cmdEndShift.UseVisualStyleBackColor = True
        '
        'cmbNameEndShift
        '
        Me.cmbNameEndShift.FormattingEnabled = True
        Me.cmbNameEndShift.Location = New System.Drawing.Point(211, 111)
        Me.cmbNameEndShift.Name = "cmbNameEndShift"
        Me.cmbNameEndShift.Size = New System.Drawing.Size(639, 44)
        Me.cmbNameEndShift.TabIndex = 4
        '
        'lblNameEndShift
        '
        Me.lblNameEndShift.AutoSize = True
        Me.lblNameEndShift.Location = New System.Drawing.Point(106, 119)
        Me.lblNameEndShift.Name = "lblNameEndShift"
        Me.lblNameEndShift.Size = New System.Drawing.Size(99, 36)
        Me.lblNameEndShift.TabIndex = 3
        Me.lblNameEndShift.Text = "Name"
        '
        'lblLiveTime
        '
        Me.lblLiveTime.AutoSize = True
        Me.lblLiveTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLiveTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiveTime.Location = New System.Drawing.Point(299, 34)
        Me.lblLiveTime.Name = "lblLiveTime"
        Me.lblLiveTime.Size = New System.Drawing.Size(244, 57)
        Me.lblLiveTime.TabIndex = 1
        Me.lblLiveTime.Text = "XX:XX:XX"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(12, 9)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(266, 82)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        '
        'lblLiveDate
        '
        Me.lblLiveDate.AutoSize = True
        Me.lblLiveDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLiveDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiveDate.Location = New System.Drawing.Point(549, 34)
        Me.lblLiveDate.Name = "lblLiveDate"
        Me.lblLiveDate.Size = New System.Drawing.Size(317, 57)
        Me.lblLiveDate.TabIndex = 4
        Me.lblLiveDate.Text = "YEAR-XX-XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time"
        '
        'ShiftManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 621)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLiveDate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblLiveTime)
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
    Friend WithEvents lblLiveTime As Label
    Friend WithEvents lblNameBeginShift As Label
    Friend WithEvents txtNameEndShift As TextBox
    Friend WithEvents cmbNameEndShift As ComboBox
    Friend WithEvents lblNameEndShift As Label
    Friend WithEvents cmdBeginShift As Button
    Friend WithEvents cmdEndShift As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents lblLiveDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
