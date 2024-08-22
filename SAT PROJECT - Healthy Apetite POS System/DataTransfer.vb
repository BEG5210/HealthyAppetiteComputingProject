Module DataTransfer

    Public CartName(10) As String 'Index determines its position in the cart
    Public CartPrice(10) As Decimal 'Index determines its position in the cart
    Public CartTotalPrice As Decimal 'Total prcice of all things in the cart added together
    Public CartIndex As Integer 'Determines the position in the cart. Resets to zero when cart clears or purchase is made.

    Public CosmeticCartText As String 'This is the value of the textbox

    Public CurrentCartText As String 'This stores the cart once payment is ready. this is to be printed onto a receipt.
    Public ReceiptOutput As String 'This is what stores the text that will be added to the receipt.

    Public DiscountAmt As Decimal 'This is the stored value that will be discounted from final payment

End Module