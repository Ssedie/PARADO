Public Class DatabaseSeeder

    Public Shared Sub Seed()

        Using db As New AppDbContext()

            If db.Products.Any() Then
                Return
            End If

            ' MEALS
            AddProduct(db, "Fried Chicken", "Meals", 75D)
            AddProduct(db, "Pork Adobo", "Meals", 70D)
            AddProduct(db, "Chicken Adobo", "Meals", 70D)
            AddProduct(db, "Spaghetti", "Meals", 50D)
            AddProduct(db, "Pancit", "Meals", 45D)

            AddProduct(db, "Burger Steak", "Meals", 65D)
            AddProduct(db, "Hotdog with Rice", "Meals", 45D)
            AddProduct(db, "Siomai Rice", "Meals", 50D)
            AddProduct(db, "Longganisa Rice", "Meals", 55D)
            AddProduct(db, "Tocino Rice", "Meals", 60D)

            ' SNACKS
            AddProduct(db, "Burger", "Snacks", 40D)
            AddProduct(db, "French Fries", "Snacks", 35D)
            AddProduct(db, "Sandwich", "Snacks", 30D)
            AddProduct(db, "Hotdog", "Snacks", 30D)
            AddProduct(db, "Siomai", "Snacks", 30D)

            AddProduct(db, "Turon", "Snacks", 15D)
            AddProduct(db, "Banana Cue", "Snacks", 15D)
            AddProduct(db, "Donut", "Snacks", 20D)
            AddProduct(db, "Cupcake", "Snacks", 25D)
            AddProduct(db, "Bread", "Snacks", 15D)

            ' DRINKS
            AddProduct(db, "Iced Tea", "Drinks", 50D)
            AddProduct(db, "Soft Drink", "Drinks", 45D)
            AddProduct(db, "Bottled Water", "Drinks", 30D)
            AddProduct(db, "Apple Juice", "Drinks", 25D)
            AddProduct(db, "Pineapple Juice", "Drinks", 25D)

            AddProduct(db, "Soft Drink", "Drinks", 25D)
            AddProduct(db, "Chocolate Drink", "Drinks", 25D)
            AddProduct(db, "Coffee", "Drinks", 20D)
            AddProduct(db, "Milk", "Drinks", 25D)
            AddProduct(db, "Lemonade", "Drinks", 20D)
            db.SaveChanges()

        End Using

    End Sub

    Private Shared Sub AddProduct(
        db As AppDbContext,
        name As String,
        category As String,
        price As Decimal
    )

        Dim product As New Product()

        product.Name = name
        product.Category = category
        product.Price = price
        product.IsAvailable = True

        db.Products.Add(product)

    End Sub

End Class