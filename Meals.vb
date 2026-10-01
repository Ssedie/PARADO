Public Class Meals

    Private ReadOnly productService As New ProductService()

    Private Sub Meals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMeals()

    End Sub

    Private Sub LoadMeals()

        Dim meals = productService.GetProductsByCategory("Meals")

        Dim nameLabels() As Label = {
            Label2, Label3, Label4, Label5, Label6,
            Label7, Label8, Label9, Label10, Label11
        }

        Dim priceLabels() As Label = {
            Label12, Label13, Label14, Label15, Label16,
            Label17, Label18, Label19, Label20, Label21
        }

        For i As Integer = 0 To Math.Min(meals.Count, nameLabels.Length) - 1

            nameLabels(i).Text = meals(i).Name
            priceLabels(i).Text = "₱" & meals(i).Price.ToString("0")

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Snacks.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Drinks.Show()
        Me.Hide()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Orders.Show()
        Me.Hide()

    End Sub

    Private Sub AddMeal(productIndex As Integer)

        Dim meals = productService.GetProductsByCategory("Meals")

        If productIndex >= meals.Count Then
            Return
        End If

        OrderService.AddItem(meals(productIndex))

        MessageBox.Show(
            meals(productIndex).Name & " added to order.",
            "Order Added",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddMeal(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddMeal(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AddMeal(2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddMeal(3)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AddMeal(4)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AddMeal(5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AddMeal(6)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AddMeal(7)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AddMeal(8)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AddMeal(9)
    End Sub

End Class