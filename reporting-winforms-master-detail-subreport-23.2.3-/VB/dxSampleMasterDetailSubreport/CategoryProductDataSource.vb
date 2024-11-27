Imports System.Collections.Generic

Public Class Category
    Public Property CategoryId As Integer
    Public Property CategoryName As String
    Public Property Description As String
    Public Property Products As List(Of Product)
End Class

Public Class Product
    Public Property ProductName As String
    Public Property UnitPrice As Double
End Class

Module CategoryProductDataSource
    Function GetData() As List(Of Category)
        Return New List(Of Category) From {
            New Category() With {
                .CategoryName = "Beverages",
                .Description = "Soft drinks, coffees, teas, beers, and ales",
                .Products = New List(Of Product) From {
                    New Product With {
                        .ProductName = "Chai",
                        .UnitPrice = 18
                    },
                    New Product With {
                        .ProductName = "Chang",
                        .UnitPrice = 19
                    },
                    New Product With {
                        .ProductName = "Guaraná Fantástica",
                        .UnitPrice = 4.5
                    }
                }
            },
            New Category() With {
                .CategoryName = "Condiments",
                .Description = "Sweet and savory sauces, relishes, spreads, and seasonings",
                .Products = New List(Of Product) From {
                    New Product With {
                        .ProductName = "Aniseed Syrup",
                        .UnitPrice = 10
                    },
                    New Product With {
                        .ProductName = "Chef Anton's Cajun Seasoning",
                        .UnitPrice = 22
                    },
                    New Product With {
                        .ProductName = "Chef Anton's Gumbo Mix",
                        .UnitPrice = 21.35
                    },
                    New Product With {
                        .ProductName = "Grandma's Boysenberry Spread",
                        .UnitPrice = 25
                    }
                }
            },
            New Category() With {
                .CategoryName = "Confections",
                .Description = "Desserts, candies, and sweet breads",
                .Products = New List(Of Product) From {
                    New Product With {
                        .ProductName = "Pavlova",
                        .UnitPrice = 17.45
                    },
                    New Product With {
                        .ProductName = "Teatime Chocolate Biscuits",
                        .UnitPrice = 9.2
                    },
                    New Product With {
                        .ProductName = "Sir Rodney's Marmalade",
                        .UnitPrice = 81
                    },
                    New Product With {
                        .ProductName = "Sir Rodney's Scones",
                        .UnitPrice = 10
                    },
                    New Product With {
                        .ProductName = "NuNuCa Nuß-Nougat-Creme",
                        .UnitPrice = 14
                    }
                }
            }
        }
    End Function
End Module
