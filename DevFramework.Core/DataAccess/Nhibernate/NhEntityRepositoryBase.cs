﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using System.Linq.Expressions;

namespace DevFramework.Core.DataAccess.Nhibernate
{
    public class NhEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private NhibernateHelper _nHibernateHelper;

        public NhEntityRepositoryBase(NhibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return filter==null
                    ?session.Query<TEntity>().ToList()
                    :session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
