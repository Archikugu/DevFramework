using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.Nhibernate
{
    public abstract class NhibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory;
        public virtual ISessionFactory SessionFactory { get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); } }

        protected abstract ISessionFactory InitializeFactory();
        
        public virtual ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
