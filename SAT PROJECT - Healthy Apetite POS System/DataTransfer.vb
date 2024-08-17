Module DataTransfer

    Public CartName(10) As String 'Index determines its position in the cart
    Public CartPrice(10) As Decimal 'Index determines its position in the cart
    Public CartTotalPrice As Decimal 'Total prcice of all things in the cart added together
    Public CartIndex As Integer 'Determines the position in the cart. Resets to zero when cart clears or purchase is made.

    Public CosmeticCartText As String 'This is the value of the textbox

End Module