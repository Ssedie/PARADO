Public Class OrderService

    Private Shared ReadOnly items As New List(Of OrderItem)()

    Public Shared Sub AddItem(product As Product)

        Dim existingItem = items.FirstOrDefault(
            Function(item) item.ProductId = product.Id
        )

        If existingItem IsNot Nothing Then

            existingItem.Quantity += 1

        Else

            Dim newItem As New OrderItem()

            newItem.ProductId = product.Id
            newItem.ProductName = product.Name
            newItem.Price = product.Price
            newItem.Quantity = 1

            items.Add(newItem)

        End If

    End Sub

    Public Shared Function GetItems() As List(Of OrderItem)

        Return items

    End Function

    Public Shared Function GetTotal() As Decimal

        Dim total As Decimal = 0D

        For Each item In items

            total += item.Price * item.Quantity

        Next

        Return total

    End Function

End Class