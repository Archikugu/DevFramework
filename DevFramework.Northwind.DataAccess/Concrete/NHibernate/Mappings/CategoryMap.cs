using DevFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap: ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Products");
            LazyLoad();
            Id(x => x.CategoryId, "CategoryID");
            Map(x => x.CategoryId, "CategoryID");
            Map(x => x.CategoryName, "CategoryName");
        }
    }
}
