Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class Main

    Dim output As String
    Dim filepath As String
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When this loads, make the buttons read the files and using that:
        'Establish the name
        'Establish the colour
        'Establish the item
        'Establish the items stock count
        'Establish the items price

        ReadItemCSV()

        'I'll probably use an object for this, and update my Design Solution.
    End Sub

    Private Sub ReadItemCSV()

        'defining variables
        Dim FileName As String
        Dim FileNum As Integer = FreeFile()

        FileName = "filename"                  'add name of file in quotations
        filepath = "filedirectory" + FileName  'add directory within quotations

        FileOpen(FileNum, filepath, OpenMode.Input)

        Try
            'reads each line of the file 
            Do Until EOF(FileNum)
                output = LineInput(FileNum)
                txtTest.Text += output + vbCrLf
            Loop

            FileClose(FileNum)

        Catch ex As Exception
            FileClose(FileNum)
            MsgBox("Error reading da file")
        End Try

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

    'MAXIMUM LINES IN CART TEXTBOX BEFORE SCROLLING IS NEEDED IS 17! AS OF RIGHT NOW

    'INCASE OF ANY ERRORS - there is an important annotation in the bottom of
    'application designer that may be usefull

#End Region

End Class