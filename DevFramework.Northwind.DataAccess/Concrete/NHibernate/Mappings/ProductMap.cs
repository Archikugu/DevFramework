using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Products");
            LazyLoad();
            Id(x => x.ProductId, "ProductID");
            Map(x => x.CategoryId, "CategoryID");
            Map(x => x.ProductName, "ProductName");
            Map(x => x.QuantityPerUnit, "QuantityPerUnit");
            Map(x => x.UnitPrice, "UnitPrice");
        }
    }
}