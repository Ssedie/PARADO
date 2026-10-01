Imports Microsoft.EntityFrameworkCore

Public Class AppDbContext
    Inherits DbContext

    Public Property Products As DbSet(Of Product)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlite("Data Source=app.db")
    End Sub
End Class