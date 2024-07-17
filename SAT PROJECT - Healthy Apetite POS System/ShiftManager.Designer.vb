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
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblLiveDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.TabControl1.Location = New System.Drawing.Point(8, 71)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(678, 323)
        Me.TabControl1.TabIndex = 0
        '
        'tabBeginShift
        '
        Me.tabBeginShift.Controls.Add(Me.cmdBeginShift)
        Me.tabBeginShift.Controls.Add(Me.txtNameEndShift)
        Me.tabBeginShift.Controls.Add(Me.lblNameBeginShift)
        Me.tabBeginShift.Location = New System.Drawing.Point(4, 33)
        Me.tabBeginShift.Margin = New System.Windows.Forms.Padding(2)
        Me.tabBeginShift.Name = "tabBeginShift"
        Me.tabBeginShift.Padding = New System.Windows.Forms.Padding(2)
        Me.tabBeginShift.Size = New System.Drawing.Size(670, 286)
        Me.tabBeginShift.TabIndex = 2
        Me.tabBeginShift.Text = "Begin Shift"
        Me.tabBeginShift.UseVisualStyleBackColor = True
        '
        'cmdBeginShift
        '
        Me.cmdBeginShift.Location = New System.Drawing.Point(236, 143)
        Me.cmdBeginShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdBeginShift.Name = "cmdBeginShift"
        Me.cmdBeginShift.Size = New System.Drawing.Size(249, 83)
        Me.cmdBeginShift.TabIndex = 4
        Me.cmdBeginShift.Text = "BEGIN SHIFT"
        Me.cmdBeginShift.UseVisualStyleBackColor = True
        '
        'txtNameEndShift
        '
        Me.txtNameEndShift.Location = New System.Drawing.Point(141, 72)
        Me.txtNameEndShift.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNameEndShift.Name = "txtNameEndShift"
        Me.txtNameEndShift.Size = New System.Drawing.Size(427, 32)
        Me.txtNameEndShift.TabIndex = 3
        '
        'lblNameBeginShift
        '
        Me.lblNameBeginShift.AutoSize = True
        Me.lblNameBeginShift.Location = New System.Drawing.Point(71, 77)
        Me.lblNameBeginShift.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameBeginShift.Name = "lblNameBeginShift"
        Me.lblNameBeginShift.Size = New System.Drawing.Size(70, 25)
        Me.lblNameBeginShift.TabIndex = 2
        Me.lblNameBeginShift.Text = "Name"
        '
        'tabEndShift
        '
        Me.tabEndShift.Controls.Add(Me.cmdEndShift)
        Me.tabEndShift.Controls.Add(Me.cmbNameEndShift)
        Me.tabEndShift.Controls.Add(Me.lblNameEndShift)
        Me.tabEndShift.Location = New System.Drawing.Point(4, 33)
        Me.tabEndShift.Margin = New System.Windows.Forms.Padding(2)
        Me.tabEndShift.Name = "tabEndShift"
        Me.tabEndShift.Padding = New System.Windows.Forms.Padding(2)
        Me.tabEndShift.Size = New System.Drawing.Size(670, 286)
        Me.tabEndShift.TabIndex = 3
        Me.tabEndShift.Text = "End Shift"
        Me.tabEndShift.UseVisualStyleBackColor = True
        '
        'cmdEndShift
        '
        Me.cmdEndShift.Location = New System.Drawing.Point(236, 143)
        Me.cmdEndShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEndShift.Name = "cmdEndShift"
        Me.cmdEndShift.Size = New System.Drawing.Size(249, 83)
        Me.cmdEndShift.TabIndex = 5
        Me.cmdEndShift.Text = "END SHIFT"
        Me.cmdEndShift.UseVisualStyleBackColor = True
        '
        'cmbNameEndShift
        '
        Me.cmbNameEndShift.FormattingEnabled = True
        Me.cmbNameEndShift.Location = New System.Drawing.Point(141, 72)
        Me.cmbNameEndShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbNameEndShift.Name = "cmbNameEndShift"
        Me.cmbNameEndShift.Size = New System.Drawing.Size(427, 32)
        Me.cmbNameEndShift.TabIndex = 4
        '
        'lblNameEndShift
        '
        Me.lblNameEndShift.AutoSize = True
        Me.lblNameEndShift.Location = New System.Drawing.Point(71, 77)
        Me.lblNameEndShift.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNameEndShift.Name = "lblNameEndShift"
        Me.lblNameEndShift.Size = New System.Drawing.Size(70, 25)
        Me.lblNameEndShift.TabIndex = 3
        Me.lblNameEndShift.Text = "Name"
        '
        'lblLiveTime
        '
        Me.lblLiveTime.AutoSize = True
        Me.lblLiveTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLiveTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiveTime.Location = New System.Drawing.Point(139, 28)
        Me.lblLiveTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLiveTime.Name = "lblLiveTime"
        Me.lblLiveTime.Size = New System.Drawing.Size(163, 39)
        Me.lblLiveTime.TabIndex = 1
        Me.lblLiveTime.Text = "XX:XX:XX"
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
        Me.lblLiveDate.Location = New System.Drawing.Point(306, 28)
        Me.lblLiveDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLiveDate.Name = "lblLiveDate"
        Me.lblLiveDate.Size = New System.Drawing.Size(210, 39)
        Me.lblLiveDate.TabIndex = 4
        Me.lblLiveDate.Text = "YEAR-XX-XX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 7)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 60)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "EXIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShiftManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 404)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLiveDate)
        Me.Controls.Add(Me.lblLiveTime)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ShiftManager"
        Me.Text = "Shift Manager"
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
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents lblLiveDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
