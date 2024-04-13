using DevFramework.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "dbo");
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.ProductId).HasColumnName("ProductID");
            builder.Property(x => x.CategoryId).HasColumnName("CategoryId");
            builder.Property(x => x.ProductName).HasColumnName("ProductName");
            builder.Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            builder.Property(x => x.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}
