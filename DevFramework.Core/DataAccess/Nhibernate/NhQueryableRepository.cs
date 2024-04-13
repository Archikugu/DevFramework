using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.Nhibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NhibernateHelper _nhibernateHelper;
        IQueryable<T> _entities;

        public NhQueryableRepository(NhibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper;
        }

        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }
        public virtual IQueryable<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _nhibernateHelper.OpenSession().Query<T>();
                }
                return _entities;
            }
        }
    }
}
