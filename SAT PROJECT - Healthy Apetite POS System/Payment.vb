Public Class Payment


    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide() 'Hides the payment window.
        'Also make the values be cleared
    End Sub

    Private Sub txtAmountOwed_TextChanged(sender As Object, e As EventArgs) Handles txtAmountOwed.TextChanged
        CalculateDifference()
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        CalculateDifference()
    End Sub

    Private Sub CalculateDifference()
        'How to implement a way to check for letters and spit out an error?
        Dim AmtOwed As Decimal = Val(txtAmountOwed.Text)
        Dim AmtPaid As Decimal = Val(txtAmountPaid.Text)
        Dim Difference As Decimal

        Difference = AmtOwed - AmtPaid

        txtDifference.Text = Difference.ToString("F2")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        'h
        'Check if Manual input is checked
        If chkManual.Checked = False Then '
            'User cannot edit Text Boxes
            txtAmountOwed.ReadOnly = True
            txtAmountPaid.ReadOnly = True
        ElseIf chkManual.Checked = True Then
            'User can edit Text Boxes
            txtAmountOwed.ReadOnly = False
            txtAmountPaid.ReadOnly = False
        End If

    End Sub

#Region "Notes To Self"

#End Region

#Region "What Dis Do?"

    'txtAmountOwed:
    'This text box shows the amount owed by the customer based on what they have in their cart

    'txtAmountPayed:
    'Shows the amount payed by the customer

    'txtDifference:
    'Shows the difference in amount payed and owed
    'depending on weather it is negative or positive, shows weather the customer owes money or
    'weather the cashier owes the customer money

    'cmdCompletePayment:
    'When the customer has payed what they have owed, then this button will
    'complete the payment

#End Region

End Class