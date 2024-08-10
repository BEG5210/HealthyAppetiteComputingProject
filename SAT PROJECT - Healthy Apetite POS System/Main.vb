Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class Main

    Dim output As String
    Dim filepath As String
    Dim items(31) As String

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

        ' Define arrays to store the parsed values
        Dim nums As New List(Of Integer)()
        Dim names As New List(Of String)()
        Dim colours As New List(Of String)()
        Dim prices As New List(Of Decimal)()
        Dim stocks As New List(Of Integer)()

        ' Define file variables
        Dim FileName As String = "test.csv"
        Dim filepath As String = "C:/Computing/" & FileName
        Dim FileNum As Integer = FreeFile()
        Dim i As Integer = 0

        ' Open the file
        FileOpen(FileNum, filepath, OpenMode.Input)

        Try
            ' Read each line of the file
            Do Until EOF(FileNum)
                Dim output As String = LineInput(FileNum)
                Dim fields() As String = Split(output, ",")

                ' Check if the line has the correct number of fields
                If fields.Length = 5 Then
                    nums.Add(CInt(fields(0)))
                    names.Add(fields(1) & " " & fields(2)) 'This line doesent work
                    colours.Add(fields(2))
                    prices.Add(CDec(fields(3)))
                    stocks.Add(CInt(fields(4)))
                End If

                ' Representation of data for testing
                txtTest.Text += output & vbCrLf

                ' Iterate index by 1
                i += 1

            Loop

            FileClose(FileNum)

        Catch ex As Exception
            FileClose(FileNum)
            MsgBox("Error Reading Items CSV File.")
        End Try

        ' Print the results for testing
        txtTest.Text += "Num: {" & String.Join(", ", nums.ToArray()) & "}" & vbCrLf
        txtTest.Text += "Name: {" & String.Join(", ", names.ToArray()) & "}" & vbCrLf
        txtTest.Text += "Colour: {" & String.Join(", ", colours.ToArray()) & "}" & vbCrLf
        txtTest.Text += "Price: {" & String.Join(", ", prices.ToArray()) & "}" & vbCrLf
        txtTest.Text += "Stock: {" & String.Join(", ", stocks.ToArray()) & "}" & vbCrLf

        ' Reset the index
        i = 0

        'Define the Items


    End Sub

    Private Sub cmdCash_Click(sender As Object, e As EventArgs) Handles cmdCash.Click
        'Show the payment window
        Payment.Show()
    End Sub

    Private Sub cmdDiscount_Click(sender As Object, e As EventArgs) Handles cmdDiscount.Click
        'Show the discount window
        Discount.Show()
    End Sub

    Private Sub cmdBeginEndShift_Click(sender As Object, e As EventArgs) Handles cmdBeginEndShift.Click
        'Show the Shift Maneger
        ShiftManager.Show()
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
    '
    'MakeButtonsInvisible() entirely written by CHATGTP: https://chatgpt.com/share/a6386c9e-2131-46e9-ab51-bb63ec5edfa9
#End Region

End Class