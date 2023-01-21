using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Kalem-1", CreatedDate = DateTime.Now, Price = 100, Stock = 100 },
                new Product { Id = 2, CategoryId = 2, Name = "Kitap-1", CreatedDate = DateTime.Now, Price = 100, Stock = 100 },
                new Product { Id = 3, CategoryId = 3, Name = "Defter-1", CreatedDate = DateTime.Now, Price = 100, Stock = 100 }
                );
        }
    }
}