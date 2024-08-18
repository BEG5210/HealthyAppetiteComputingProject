Public Class Payment

    ' Dim TotalPayment As Decimal = TempTotalPayment 'Total payment set to temporay total payment on main screen. done so other things can function while cart system is worked on.

    'DEFINING SOME VARIABLES:
    'denominations:            {5,10,20,50, 1, 2, 5,10,20,50,100}
    Dim CashNum As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}    '11 values (11-1)
    '                          [   CENTS   ][      DOLLARS      ]
    '---------------------------------------------------------------------------------
    'denominations:               {5,10,20,50, 1, 2, 5,10,20,50,100}
    Dim CashChange As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} '11 values (11-1)
    '                             [   CENTS   ][      DOLLARS      ]
    '---------------------------------------------------------------------------------
    'denominations:              {5,10,20,50, 1, 2, 5,10,20,50,100}
    Dim CashTotal As Decimal() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}  '11 values (11-1)
    '                            [   CENTS   ][      DOLLARS      ]

    'CashChange - Number of each denomination of currency to be given as change
    'CashNum - Number of each denomination of currency pressed
    'CashTotal - Total amount of cash in dollars that the customer has given

    Dim ImportedTotal As Decimal


    Sub CheckForCheckBoxes()

        'Check if Manual input is checked
        If chkManual.Checked = False Then
            'User cannot edit Text Boxes
            txtAmountOwed.ReadOnly = True
            txtMskAmountPaid.ReadOnly = True

            'Set Visibility of text boxes acordingly
            txtAmountPaid.Visible = True
            txtMskAmountPaid.Visible = False
        ElseIf chkManual.Checked = True Then
            'User can edit Text Boxes
            txtAmountOwed.ReadOnly = False
            txtMskAmountPaid.ReadOnly = False

            'Set Visibility of text boxes acordingly
            txtAmountPaid.Visible = False
            txtMskAmountPaid.Visible = True
        End If

    End Sub

    Private Sub chkManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkManual.CheckedChanged
        CheckForCheckBoxes()
    End Sub




    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForCheckBoxes()
        'txtAmountOwed.Text = TotalPayment.ToString("F2")
        ImportedTotal = CartTotalPrice
        txtAmountOwed.Text = ImportedTotal.ToString("C")
    End Sub

    'Hiding Payment Window - Values reset
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub





    'When the textboxes for ammount paid / changed, well... change, then calculate difference
    Private Sub txtAmountOwed_TextChanged(sender As Object, e As EventArgs) Handles txtAmountOwed.TextChanged
        CalculateDifference()
    End Sub

    Private Sub txtMskAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtMskAmountPaid.TextChanged
        CalculateDifference()
        txtAmountPaid.Text = txtMskAmountPaid.Text
    End Sub

    'Function for Calculate the difference in cost 
    Private Sub CalculateDifference()
        'How to implement a way to check for letters and spit out an error?

        'Declaring Values:
        Dim AmtOwed As Decimal = Val(txtAmountOwed.Text)
        Dim AmtPaid As Decimal = Val(txtMskAmountPaid.Text)
        Dim Difference As Decimal

        Difference = AmtOwed - AmtPaid

        'Check weather cmdCompletePayment should be visible
        'essentially, let the transaction complete if the transaction is in
        'the favor of both parties or the company


        ' Check if Difference is less than or equal to zero
        If Difference <= 0 Then
            ' Difference is zero or negative, show the cmdCompletePayment button
            cmdCompletePmt.Visible = True
        Else
            ' Difference is positive, hide the cmdCompletePayment button
            cmdCompletePmt.Visible = False
        End If

        txtDifference.Text = Difference.ToString("F2")
    End Sub

    'TODO:
    'When any of dis occours, make it so it itirates through the index
    'and calculates the total. of each boio, and make it the ammount paid.
#Region "Code for when Cash Buttons Pressed"

    Private Sub cmd5c_Click(sender As Object, e As EventArgs) Handles cmd5c.Click
        CashNum(0) += 1
        txt5c.Text = CashNum(0)

        CashTotal(0) = Val(CashNum(0)) * 0.05

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd10c_Click(sender As Object, e As EventArgs) Handles cmd10c.Click
        CashNum(1) += 1
        txt10c.Text = CashNum(1)

        CashTotal(1) = Val(CashNum(1)) * 0.1

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd20c_Click(sender As Object, e As EventArgs) Handles cmd20c.Click
        CashNum(2) += 1
        txt20c.Text = CashNum(2)

        CashTotal(2) = Val(CashNum(2)) * 0.2

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd50c_Click(sender As Object, e As EventArgs) Handles cmd50c.Click
        CashNum(3) += 1
        txt50c.Text = CashNum(3)

        CashTotal(3) = Val(CashNum(3)) * 0.5

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd1d_Click(sender As Object, e As EventArgs) Handles cmd1d.Click
        CashNum(4) += 1
        txt1d.Text = CashNum(4)

        CashTotal(4) = CashNum(4)

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd2d_Click(sender As Object, e As EventArgs) Handles cmd2d.Click
        CashNum(5) += 1
        txt2d.Text = CashNum(5)

        CashTotal(5) = Val(CashNum(5)) * 2

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd5d_Click(sender As Object, e As EventArgs) Handles cmd5d.Click
        CashNum(6) += 1
        txt5d.Text = CashNum(6)

        CashTotal(6) = Val(CashNum(6)) * 5

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd10d_Click(sender As Object, e As EventArgs) Handles cmd10d.Click
        CashNum(7) += 1
        txt10d.Text = CashNum(7)

        CashTotal(7) = Val(CashNum(7)) * 10

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd20d_Click(sender As Object, e As EventArgs) Handles cmd20d.Click
        CashNum(8) += 1
        txt20d.Text = CashNum(8)

        CashTotal(8) = Val(CashNum(8)) * 20

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd50d_Click(sender As Object, e As EventArgs) Handles cmd50d.Click
        CashNum(9) += 1
        txt50d.Text = CashNum(9)

        CashTotal(9) = Val(CashNum(9)) * 50

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub cmd100d_Click(sender As Object, e As EventArgs) Handles cmd100d.Click
        CashNum(10) += 1
        txt100d.Text = CashNum(10)

        CashTotal(10) = Val(CashNum(10)) * 100 '

        CalculateTotalFromCashGiven()
    End Sub

    Private Sub txtDifference_TextChanged(sender As Object, e As EventArgs) Handles txtDifference.TextChanged
        If Val(txtDifference.Text) <= 0 Then

        End If
    End Sub

    Sub CalculateTotalFromCashGiven()

        Dim TotalSum As Decimal
        Dim index As Integer = 0

        While index <= 10
            TotalSum += CashTotal(index) / 100 'devide by 100 to make it actually word with formatting of the textbox. Absalutely Dumb, yet genius.
            index += 1                         'iterates the index to the next position in the array
        End While

        txtMskAmountPaid.Text = TotalSum

    End Sub

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

#Region "thing from SRS to refer to"
    'Once the customer is ready to pay, and tells the cashier how they
    'will be paying,the cashier selects either card or Cash.
    'If either one is selected, first calculate the total cost
    'if cash was selected, cashier inputs what the customer presents
    'if what the cashier inputed is less than the total cost, display the difference,
    'and close the cash window to the home screen. //allow for customer to get more cash,
    'or change payment method
    'if it is the exact cost, then {complete payment}
    'if the customer gives more than the total amount, the cashier gives the
    'customer the difference, the system reduces the amount in the register pool,
    'and then {complete payment}
#End Region

End Class