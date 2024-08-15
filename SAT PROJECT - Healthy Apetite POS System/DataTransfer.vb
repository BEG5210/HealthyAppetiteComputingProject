Module DataTransfer
    'Public strVella As String = "Vella" 'Testing

    'Define Varaibles for cart functions
    Public CartPLace As Integer = 0
    Public CosmeticCartPlace As Integer = CartPLace + 1

    Public ItemCartQuantity(31) As Integer

    Public CartList As String 'this index is suposed to save each sort of "part" in the cart, so that they are self contained. whenever the cart needs to be updated, clear it, and cycle back through this index and but them in

    Public CartItemInList(31) As Boolean 'All should be equal to false initialy. set to true once in list
    Public CartWriteArrayText(31) As String 'The text for each item in array. saved here, and iterated through to display on thing
    Public CartWriteArrayIndex As Integer 'The index of cart write array

End Module
