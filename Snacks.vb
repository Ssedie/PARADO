Public Class Snacks

    Private ReadOnly productService As New ProductService()

    Private Sub Snacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSnacks()
    End Sub

    Private Sub LoadSnacks()

        Dim snacks = productService.GetProductsByCategory("Snacks")

        Dim nameLabels() As Label = {
            Label2, Label3, Label4, Label5, Label6,
            Label7, Label8, Label9, Label10, Label11
        }

        Dim priceLabels() As Label = {
            Label12, Label13, Label14, Label15, Label16,
            Label17, Label18, Label19, Label20, Label21
        }

        For i As Integer = 0 To Math.Min(snacks.Count, nameLabels.Length) - 1

            nameLabels(i).Text = snacks(i).Name
            priceLabels(i).Text = "₱" & snacks(i).Price.ToString("0")

        Next

    End Sub

    Private Sub AddSnack(productIndex As Integer)

        Dim snacks = productService.GetProductsByCategory("Snacks")

        If productIndex >= snacks.Count Then
            Return
        End If

        OrderService.AddItem(snacks(productIndex))

        MessageBox.Show(
            snacks(productIndex).Name & " added to order.",
            "Order Added",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    ' MEALS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Meals.Show()
        Me.Hide()
    End Sub

    ' SNACKS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Already on Snacks menu
    End Sub

    ' DRINKS
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Drinks.Show()
        Me.Hide()
    End Sub

    ' BACK TO ORDERS
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Orders.Show()
        Me.Hide()
    End Sub

    ' SNACK ORDER BUTTONS

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddSnack(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddSnack(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AddSnack(2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddSnack(3)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AddSnack(4)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AddSnack(5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AddSnack(6)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AddSnack(7)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AddSnack(8)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AddSnack(9)
    End Sub

End Class