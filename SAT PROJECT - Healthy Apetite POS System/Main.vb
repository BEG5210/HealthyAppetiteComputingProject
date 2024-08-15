Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class Main

    ' Redundant Variables
    ' Dim output As String
    ' Dim filepath As String
    ' Dim items(31) As String

    ' Define arrays to store the parsed values
    Dim nums() As Integer
    Dim names() As String
    Dim colours() As String
    Dim prices() As Decimal
    Dim stocks() As Integer

    ' Define file variables
    Dim FileName As String = "test.csv"
    Dim filepath As String = "C:/Computing/" & FileName
    Dim FileNum As Integer = FreeFile()

    'Define index for adding cart items
    Dim Index As Integer = 0

    Dim CartPlacePrice(31) As Decimal
    Dim Thing As Decimal

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MakeButtonsInvisible()

        'When this loads, make the buttons read the files and using that:
        'Establish the name
        'Establish the colour
        'Establish the item
        'Establish the items stock count
        'Establish the items price

        ReadItemCSV()

        'I'll probably use an object for this, and update my Design Solution.
    End Sub

    Private Sub MakeButtonsInvisible() ' Sets buttons to be invisible. this is done in code, instead of in design, so when viewing layout it is easier to see the buttons when they arent hidden.

        ' Manually set each button's visibility to False
        cmd1_1.Visible = False
        cmd2_1.Visible = False
        cmd3_1.Visible = False
        cmd4_1.Visible = False

        cmd1_2.Visible = False
        cmd2_2.Visible = False
        cmd3_2.Visible = False
        cmd4_2.Visible = False

        cmd1_3.Visible = False
        cmd2_3.Visible = False
        cmd3_3.Visible = False
        cmd4_3.Visible = False

        cmd1_4.Visible = False
        cmd2_4.Visible = False
        cmd3_4.Visible = False
        cmd4_4.Visible = False

        cmd1_5.Visible = False
        cmd2_5.Visible = False
        cmd3_5.Visible = False
        cmd4_5.Visible = False

        cmd1_6.Visible = False
        cmd2_6.Visible = False
        cmd3_6.Visible = False
        cmd4_6.Visible = False

        cmd1_7.Visible = False
        cmd2_7.Visible = False
        cmd3_7.Visible = False
        cmd4_7.Visible = False

        cmd1_8.Visible = False
        cmd2_8.Visible = False
        cmd3_8.Visible = False
        cmd4_8.Visible = False

    End Sub

    Private Sub ReadItemCSV()

        'Define Variable for Parsing Index
        Dim i As Integer = 0

        ' Initialize arrays to a reasonable size (if the number of lines in the CSV is known, use that size)
        ReDim nums(0)
        ReDim names(0)
        ReDim colours(0)
        ReDim prices(0)
        ReDim stocks(0)

        ' Open the file
        FileOpen(FileNum, filepath, OpenMode.Input)

        Try
            ' Read each line of the file
            Do Until EOF(FileNum)
                Dim output As String = LineInput(FileNum)
                Dim fields() As String = Split(output, ",")

                ' Check if the line has the correct number of fields
                If fields.Length = 5 Then
                    ' Resize the arrays to accommodate the new element
                    ReDim Preserve nums(i)
                    ReDim Preserve names(i)
                    ReDim Preserve colours(i)
                    ReDim Preserve prices(i)
                    ReDim Preserve stocks(i)

                    nums(i) = CInt(fields(0))
                    names(i) = fields(1)
                    colours(i) = fields(2)
                    prices(i) = CDec(fields(3))
                    stocks(i) = CInt(fields(4))

                    ' Iterate index by 1
                    i += 1
                End If

                ' Representation of data for testing
                txtTest.Text += output & vbCrLf
            Loop

            FileClose(FileNum)

        Catch ex As Exception
            FileClose(FileNum)
            MsgBox("Error Reading Items CSV File." + vbCrLf + "File may be open, or does not exist")
        End Try

        ' Print the results for testing
        txtTest.Text += "Num: {" & String.Join(", ", nums) & "}" & vbCrLf
        txtTest.Text += "Name: {" & String.Join(", ", names) & "}" & vbCrLf
        txtTest.Text += "Colour: {" & String.Join(", ", colours) & "}" & vbCrLf
        txtTest.Text += "Price: {" & String.Join(", ", prices) & "}" & vbCrLf
        txtTest.Text += "Stock: {" & String.Join(", ", stocks) & "}" & vbCrLf

        'Define variables for button loading
        Dim x As Integer = 0
        Dim Btns As Control() =
            {cmd1_1, cmd2_1, cmd3_1, cmd4_1,        'There are 32 buttons here
             cmd1_2, cmd2_2, cmd3_2, cmd4_2,        'The array is 31
             cmd1_3, cmd2_3, cmd3_3, cmd4_3,
             cmd1_4, cmd2_4, cmd3_4, cmd4_4,
             cmd1_5, cmd2_5, cmd3_5, cmd4_5,
             cmd1_6, cmd2_6, cmd3_6, cmd4_6,
             cmd1_7, cmd2_7, cmd3_7, cmd4_7,
             cmd1_8, cmd2_8, cmd3_8, cmd4_8}

        'load the buttons
        Do While x < i
            Btns(x).Visible = True
            Btns(x).Text = names(x)
            x += 1
        Loop

        'Reset the index(s)
        i = 0
        x = 0

    End Sub

    Private Sub ResertCartArrays()
        'Resets cart arrays
    End Sub

    Private Sub CalculateTotalCost()
        'Calculates Total Cost

        'Itterate through cart item total cost and add them together for total
    End Sub

    Private Sub cmdCash_Click(sender As Object, e As EventArgs) Handles cmdCash.Click
        MsgBox("This feature is not yet completed")

        'Show the payment window
        Payment.Show()
    End Sub

    Private Sub cmdDiscount_Click(sender As Object, e As EventArgs) Handles cmdDiscount.Click
        MsgBox("This feature is not yet completed")

        'Show the discount window
        Discount.Show()
    End Sub

    Private Sub cmdBeginEndShift_Click(sender As Object, e As EventArgs) Handles cmdBeginEndShift.Click
        MsgBox("This feature is not yet completed")

        'Show the Shift Maneger
        ShiftManager.Show()
    End Sub

    Private Sub cmd1_1_Click(sender As Object, e As EventArgs) Handles cmd1_1.Click
        'Set index pos to relevant place
        Index = 0
        ItemCartQuantity(Index) += 1
        Thing = Val(CartPlacePrice(CartPLace) + prices(0))
        CartPlacePrice(CartPLace) = Thing


        If CartItemInList(Index) = False Then
            CartItemInList(Index) = True

            'Hacky solution to rounding decimal places
            Dim totalprice As Decimal = CartPlacePrice(CartPLace)
            totalprice = totalprice.ToString("F2")

            'Make the cart go cart moment idk im tired.
            CartList = CStr(CosmeticCartPlace) + " - " + names(Index) + " x " + CStr(ItemCartQuantity(Index)) + vbCrLf _
            + "          " + CStr(ItemCartQuantity(Index)) + " x " + CStr(totalprice)

            CartWriteArrayText(CartPLace) = CartList

            RefreshCart()

        Else
            CartItemInList(Index) = True

            'Hacky solution to rounding decimal places
            Dim totalprice As Decimal = CartPlacePrice(CartPLace)
            totalprice = totalprice.ToString("F2")

            'Make the cart go cart moment idk im tired.
            CartList = CStr(CosmeticCartPlace) + " - " + names(Index) + " x " + CStr(ItemCartQuantity(Index)) + vbCrLf _
            + "          " + CStr(ItemCartQuantity(Index)) + " x " + CStr(totalprice)

            CartWriteArrayText(CartPLace) = CartList

            RefreshCart()
        End If



    End Sub

    Private Sub cmd2_1_Click(sender As Object, e As EventArgs) Handles cmd2_1.Click
        'Set index pos to relevant place
        Index = 1
        ItemCartQuantity(Index) += 1
        Thing = Val(CartPlacePrice(CartPLace) + prices(0))
        CartPlacePrice(CartPLace) = Thing

        'Hacky solution to rounding decimal places
        Dim totalprice As Decimal = CartPlacePrice(CartPLace)
        totalprice = totalprice.ToString("F2")

        'Make the cart go cart moment idk im tired.
        CartList = CStr(CosmeticCartPlace) + " - " + names(Index) + " x " + CStr(ItemCartQuantity(Index)) + vbCrLf _
            + "          " + CStr(ItemCartQuantity(Index)) + " x " + CStr(totalprice)

        RefreshCart()

    End Sub

    Private Sub RefreshCart()
        txtCart.Text = ""
        txtCart.Text = CartList
    End Sub

    Private Sub txtCart_TextChanged(sender As Object, e As EventArgs) Handles txtCart.TextChanged

    End Sub

    Private Sub cmdCard_Click(sender As Object, e As EventArgs) Handles cmdCard.Click
        MsgBox("This feature is not yet completed")
    End Sub

    Private Sub cmdClearOrder_Click(sender As Object, e As EventArgs) Handles cmdClearOrder.Click
        MsgBox("This feature is not yet completed")
    End Sub

    Private Sub cmdEditItems_Click(sender As Object, e As EventArgs) Handles cmdEditItems.Click
        MsgBox("This feature is not yet completed")
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    'Testing:
    'Private Sub cmd1_1_Click(sender As Object, e As EventArgs) Handles cmd1_1.Click
    '   MsgBox(strVella)
    'End Sub

#Region "------ IMPORTANT INFO -----------------------------------------"
    '
    '******************* ITEM BUTTON NAME FORMATTING ***************
    '
    'btnX_Y
    'in witch x is the horizontal (effectivley the columb) in
    'witch the furthur right you are, the higher the number
    'and in witch y is the vertical (effectivley the row) in
    'witch the furthur down you are, the higher the number
    '
    '***************************************************************
    '
#End Region

#Region "------ NOTES TO SELF ------------------------------------------"
    '
    'MAXIMUM LINES IN CART TEXTBOX BEFORE SCROLLING IS NEEDED IS 17! AS OF RIGHT NOW
    '
    'INCASE OF ANY ERRORS - there is an important annotation in the bottom of
    'application designer that may be usefull
    '
#End Region

#Region "------ CREDITS ------------------------------------------------------"
    '
    'Portions of "ReadItemCSV()" were written by chatgtp, specifically the portions wwhere data was saved to lists
    'https://chatgpt.com/share/3bf6eebb-ae51-47af-9ac6-a31174ea0ca2
    '
    'MakeButtonsInvisible() entirely written by CHATGTP: https://chatgpt.com/share/a6386c9e-2131-46e9-ab51-bb63ec5edfa9
    '
    'Item Click: https://chatgpt.com/share/28188c23-bdb4-43aa-89e7-a2bce8dbaed2
#End Region

End Class