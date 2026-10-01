Public Class ProductService

    Public Function GetAllProducts() As List(Of Product)

        Using db As New AppDbContext()
            Return db.Products.ToList()
        End Using

    End Function

    Public Function GetProductsByCategory(category As String) As List(Of Product)

        Using db As New AppDbContext()
            Return db.Products.
                Where(Function(p) p.Category = category AndAlso p.IsAvailable).
                ToList()
        End Using

    End Function

    Public Sub AddProduct(name As String,
                           category As String,
                           price As Decimal)

        Using db As New AppDbContext()

            Dim product As New Product With {
                .Name = name,
                .Category = category,
                .Price = price,
                .IsAvailable = True
            }

            db.Products.Add(product)
            db.SaveChanges()

        End Using

    End Sub

End Class