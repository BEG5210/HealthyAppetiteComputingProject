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
    Private Property pColour As Color
    Private Property pName As String
    Private Property pPrice As Decimal
    Private Property pStock As Integer

    'Assigning Public Properties
    Public Property Colour() As Color
        Get

        End Get
        Set(value As Color)

        End Set
    End Property

    Public Property Name() As String
        Get

        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Price() As Decimal
        Get

        End Get
        Set(value As Decimal)

        End Set
    End Property

    Public Property Stock() As Integer
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property

End Class