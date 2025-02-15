﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        //sadece northwindcontexte bağımlı olmasın diye dependencyInjection
        private IDbSet<T> _entities;


        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this.Entities;
        //Table Entities return eder;
        // context kapamadan iki sorgu arasına business logic eklemek istersek kullanılır her projede yer almaz.

        protected virtual IDbSet<T> Entities
        {
            get
            {

                if (_entities == null)
                {
                    _entities = _context.Set<T>();

                }
                return _entities;
            }
        }
    
    }
}
