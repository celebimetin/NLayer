using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature { Id = 1, Color = "Mavi-Kalem", Height = 100, Width = 200, ProductId = 1 },
                new ProductFeature { Id = 2, Color = "Mavi-Kitap", Height = 100, Width = 200, ProductId = 2 },
                new ProductFeature { Id = 3, Color = "Mavi-Defter", Height = 100, Width = 200, ProductId = 3 }
                );
        }
    }
}