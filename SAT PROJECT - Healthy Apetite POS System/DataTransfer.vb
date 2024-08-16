Module DataTransfer
    'Public strVella As String = "Vella" 'Testing

    'Define Varaibles for cart functions
    Public CartPLace As Integer = 0
    Public CosmeticCartPlace As Integer = CartPLace + 1

    Public ItemCartQuantity(31) As Integer

    Public CartList As String 'this index is suposed to save each sort of "part" in the cart, so that they are self contained. whenever the cart needs to be updated, clear it, and cycle back through this index and but them in

    Public CartItemInList(31) As Boolean 'All should be equal to false initialy. set to true once in list
    Public CartWriteArrayText(31) As String 'The text for each item in array. saved here, and iterated through to display on thing
    'Public CartWriteArrayIndex As Integer 'The index of cart write array

    Dim LowestPosition As Integer = 0   'saves the loves position
    Dim CartArray(31) As String         'position is defined by what button it is. the number in it is the position in cart

    'When an item is pressded, check teh cart array in index, and see if there is a value
    'if it isnt zero, then that is the index for the the item proprty arrays

    'Do the things For the values
    'Get lowestPosition, and if its not found in cart array, then that items position becomes the lowest position
    'lowest position increases by one
    'if the same item is pressed, 


    'Temp
    Public TempTotalPayment As Decimal = 0

End Module