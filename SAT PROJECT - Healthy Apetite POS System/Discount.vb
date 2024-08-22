Public Class Discount

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub chkSpecificItemToggle_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpecificItemToggle.CheckedChanged

        'Show dropdown box, and allow user to select an item in the cart do be discounted
        If chkSpecificItemToggle.Checked = True Then
            lblDiscountInstruction.Visible = True
            lblOveralPaymentNotifyerLabel.Visible = False
            cmbxItemSelect.Visible = True
        ElseIf chkSpecificItemToggle.Checked = False Then
            lblDiscountInstruction.Visible = False
            lblOveralPaymentNotifyerLabel.Visible = True
            cmbxItemSelect.Visible = False
        End If

    End Sub

    Private Sub Checks(sender As Object, e As EventArgs) Handles radPercentageDiscount.CheckedChanged, radExactDiscount.CheckedChanged
        ' Determine which radio button was checked and perform the appropriate action
        If radPercentageDiscount.Checked Then
            txtOffFinalPrice.Enabled = False
            txtPercentOff.Enabled = True

        ElseIf radExactDiscount.Checked Then
            txtOffFinalPrice.Enabled = True
            txtPercentOff.Enabled = False

        End If
    End Sub

    Private Sub cmdApplyDiscount_Click(sender As Object, e As EventArgs) Handles cmdApplyDiscount.Click
        If radExactDiscount.Checked = True Then
            DiscountAmt = Val(txtOffFinalPrice.Text)
        ElseIf radPercentageDiscount.Checked = True Then
            MsgBox("Percentage Discounts are not implimented yet. please apply a Exact Discount Instead!")
        Else
            MsgBox("No Discount Type Selected. Please Choose what kind of discount you would like to do")
        End If
    End Sub





#Region "------ IMPORTANT INFO -----------------------------------------"
#End Region

#Region "------ NOTES TO SELF ------------------------------------------"
#End Region

End Class