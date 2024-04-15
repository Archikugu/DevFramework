using DevFramework.Northwind.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "dbo");
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryId).HasColumnName("CategoryID");
            builder.Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}
