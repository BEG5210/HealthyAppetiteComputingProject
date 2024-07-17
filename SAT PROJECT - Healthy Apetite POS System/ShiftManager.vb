Public Class ShiftManager

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        lblLiveTime.Text = TimeString
        lblLiveDate.Text = DateString
        'Credit: https://www.youtube.com/watch?v=QJmA7XKQ3GM
    End Sub


#Region "------ IMPORTANT INFO -----------------------------------------"
#End Region

#Region "------ NOTES TO SELF ------------------------------------------"
#End Region

End Class