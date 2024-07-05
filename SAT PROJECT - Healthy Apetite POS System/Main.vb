Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When this loads, do the button things
    End Sub

    Private Sub cmdCash_Click(sender As Object, e As EventArgs) Handles cmdCash.Click
        Payment.Show()
    End Sub

    '------ IMPORTANT INFO -----------------------------------------
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
    '--------------------------------------------------------------

#Region "Notes To Self"

    'MAXIMUM LINES IN CART TEXTBOX BEFORE SCROLLING IS NEEDED IS 17! AS OF RIGHT NOW

    'INCASE OF ANY ERRORS - there is an important annotation in the bottom of
    'application designer that may be usefull



#End Region
End Class
