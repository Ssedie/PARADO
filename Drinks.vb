Public Class Drinks

    Private ReadOnly productService As New ProductService()

    Private Sub Drinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrinks()
    End Sub

    Private Sub LoadDrinks()

        Dim drinks = productService.GetProductsByCategory("Drinks")

        Dim nameLabels() As Label = {
            Label2, Label3, Label4, Label5, Label6,
            Label7, Label8, Label9, Label10, Label11
        }

        Dim priceLabels() As Label = {
            Label12, Label13, Label14, Label15, Label16,
            Label17, Label18, Label19, Label20, Label21
        }

        For i As Integer = 0 To Math.Min(drinks.Count, nameLabels.Length) - 1

            nameLabels(i).Text = drinks(i).Name
            priceLabels(i).Text = "₱" & drinks(i).Price.ToString("0")

        Next

    End Sub


    ' MEALS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Meals.Show()
        Me.Hide()
    End Sub


    ' SNACKS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Snacks.Show()
        Me.Hide()
    End Sub


    ' DRINKS button - already on Drinks page
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Do nothing
    End Sub


    ' BACK TO ORDERS
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Orders.Show()
        Me.Hide()
    End Sub


    ' ADD DRINK
    Private Sub AddDrink(productIndex As Integer)

        Dim drinks = productService.GetProductsByCategory("Drinks")

        If productIndex >= drinks.Count Then
            Return
        End If

        OrderService.AddItem(drinks(productIndex))

        MessageBox.Show(
            drinks(productIndex).Name & " added to order.",
            "Order Added",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub


    ' ORDER BUTTONS
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddDrink(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddDrink(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AddDrink(2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddDrink(3)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AddDrink(4)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AddDrink(5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AddDrink(6)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AddDrink(7)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AddDrink(8)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AddDrink(9)
    End Sub

End Class