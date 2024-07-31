Public Class Items

#Region "What is this class for?"
    'this class is meant to save the data of the various items for sale, including their:
    'stock
    'colour
    'name
    'price
    'and more (Probably)
    '
    'after the csv containing this info is read, it will be saved here.
    'once the user is ready to exit, then the csv is saved, using the updated data
    'witch is stored here.
#End Region

    'Assigning Private Properties
    Public Property pColour As String
    Public Property pName As String
    Public Property pPrice As Decimal
    Public Property pStock As Integer

    'Assigning Public Properties
    Public Property Colour() As String
        Get
            Return pColour
        End Get
        Set(value As String)
            pColour = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return pName
        End Get
        Set(value As String)
            pName = value
        End Set
    End Property

    Public Property Price() As Decimal
        Get
            Return pPrice
        End Get
        Set(value As Decimal)
            pPrice = value
        End Set
    End Property

    Public Property Stock() As Integer
        Get
            Return pStock
        End Get
        Set(value As Integer)
            pStock = value
        End Set
    End Property

    Public Sub New(ByVal colour As String, ByVal name As String, ByVal price As Decimal, ByVal stock As Integer)
        colour = pColour
        name = pName
        price = pPrice
        stock = pStock

    End Sub

End Class