Public Class Orders

    Private orderList As New ListBox()
    Private totalLabel As New Label()

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateOrderDisplay()
        LoadOrder()
    End Sub

    Private Sub Orders_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadOrder()
    End Sub

    Private Sub CreateOrderDisplay()

        ' Order list
        orderList.Location = New Point(500, 285)
        orderList.Size = New Size(250, 50)
        orderList.Font = New Font("Segoe UI", 10)
        orderList.BorderStyle = BorderStyle.FixedSingle

        Me.Controls.Add(orderList)

        ' Total label
        totalLabel.Location = New Point(500, 340)
        totalLabel.Size = New Size(250, 35)
        totalLabel.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        totalLabel.ForeColor = Color.FromArgb(35, 85, 120)
        totalLabel.TextAlign = ContentAlignment.MiddleRight
        totalLabel.Text = "TOTAL: ₱0"

        Me.Controls.Add(totalLabel)

    End Sub

    Private Sub LoadOrder()

        orderList.Items.Clear()

        Dim items = OrderService.GetItems()

        If items.Count = 0 Then

            orderList.Items.Add("No items in order.")
            totalLabel.Text = "TOTAL: ₱0"

            Return

        End If

        For Each item In items

            Dim subtotal As Decimal =
                item.Price * item.Quantity

            orderList.Items.Add(
                item.ProductName &
                " x" &
                item.Quantity &
                " - ₱" &
                subtotal.ToString("0")
            )

        Next

        totalLabel.Text =
            "TOTAL: ₱" &
            OrderService.GetTotal().ToString("0")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Meals.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Snacks.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Drinks.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

End Class