Public Class Discount

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub chkSpecificItemToggle_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecificItemToggle.CheckedChanged

        'Show dropdown box, and allow user to select an item in the cart do be discounted
        If chkSpecificItemToggle.Checked = True Then
            lblDiscountInstruction.Visible = True
            cmbxItemSelect.Visible = True
        ElseIf chkSpecificItemToggle.Checked = False Then
            lblDiscountInstruction.Visible = False
            cmbxItemSelect.Visible = False
        End If

    End Sub





#Region "------ IMPORTANT INFO -----------------------------------------"
#End Region

#Region "------ NOTES TO SELF ------------------------------------------"
#End Region

End Class