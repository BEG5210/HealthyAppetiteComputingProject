Module DataTransfer
    'Public strVella As String = "Vella" 'Testing

    'Define Varaibles for cart functions
    Public CartPLace As Integer = 0
    Public CosCartPlace As Integer = CartPLace + 1

    Public ItemCartQuantity(31) As Integer

    Public CartList As String 'this index is suposed to save each sort of "part" in the cart, so that they are self contained. whenever the cart needs to be updated, clear it, and cycle back through this index and but them in

End Module
