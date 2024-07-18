Public Class Payment

    Dim CashNum As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} '11 values
    'denominations:         {5,10,20,50, 1, 2, 5,10,20,50,100}
    '                       [   CENTS   ][      DOLLARS      ]
    'CashNum - Number of each denomination of currency pressed

    Dim CashChange As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} '11 values
    'denominations:               {5,10,20,50, 1, 2, 5,10,20,50,100}
    '                             [   CENTS   ][      DOLLARS      ]
    'CashChange - Number of each denomination of currency to be given as change

#Region "Manual input Checkbox Check Code"
    Sub CheckForCheckBoxes()

        'Check if Manual input is checked
        If chkManual.Checked = False Then
            'User cannot edit Text Boxes
            txtAmountOwed.ReadOnly = True
            txtAmountPaid.ReadOnly = True
        ElseIf chkManual.Checked = True Then
            'User can edit Text Boxes
            txtAmountOwed.ReadOnly = False
            txtAmountPaid.ReadOnly = False
        End If

    End Sub

    Private Sub chkManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        CheckForCheckBoxes()
    End Sub
#End Region

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForCheckBoxes()

        ToolTip1.SetToolTip(chkManual, "when enabled, user must input values into the below textboxes manually.")
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Hide() 'Hides the payment window.
        'TODO: make the values be cleared
    End Sub

    Private Sub txtAmountOwed_TextChanged(sender As Object, e As EventArgs) Handles txtAmountOwed.TextChanged
        CalculateDifference()
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        CalculateDifference()
    End Sub

    Private Sub CalculateDifference()
        'How to implement a way to check for letters and spit out an error?

        'Declaring Values:
        Dim AmtOwed As Decimal = Val(txtAmountOwed.Text)
        Dim AmtPaid As Decimal = Val(txtAmountPaid.Text)
        Dim Difference As Decimal

        Difference = AmtOwed - AmtPaid

        'Check weather cmdCompletePayment should be visible
        'essentially, let the transaction complete if the transaction is in
        'the favor of both parties or the company

        'TODO: Make it Work
        Dim i As Integer = Val(Difference)

        If i = 0 Or i >= 0 Then
            cmdCompletePayment.Visible = True
        ElseIf i <= 0 Then
            cmdCompletePayment.Visible = False
        End If

        txtDifference.Text = Difference.ToString("F2")
    End Sub

#Region "Code for when Cash Buttons Pressed"

#End Region

    '----- CODE ENDS HERE -----------------------------------------

#Region "------ IMPORTANT INFO -----------------------------------------"

    '********* CASH STRING INDEXES AND WHAT THEY ARE *******
    'FORMAT: [INDEX] - [CURRENCY THAT IS SAVED TO THAT INDEX]
    '0 - 5c
    '1 - 10c
    '2 - 20c
    '3 - 50c
    '4 - 1d
    '5 - 2d
    '6 - 5d
    '7 - 10d
    '8 - 20d
    '9 - 50d
    '10 - 100d
    '********************************************************

    '******* WHAT EACH TEXTBOX DOES *************************
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
    '*******************************************************

#End Region

#Region "------ NOTES TO SELF ------------------------------------------"
#End Region

End Class