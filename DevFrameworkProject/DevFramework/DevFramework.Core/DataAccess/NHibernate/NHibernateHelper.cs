using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public abstract class NHibernateHelper : IDisposable
    { //package manager console => Devframework.core  => install-package nhibernate

        private static ISessionFactory _sessionFactory;
        
        public virtual ISessionFactory SessionFactory
        {// virtual olmasının sebebi orm lazyloading gibi navigation property tek bir nesenden bağlantılı nesneleri getirebilmesi için ihtiyaç duyuyor.
            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
        }


        protected abstract ISessionFactory InitializeFactory();
        //oracle mı mysql mi kendisi factory yollasın hepsinde farklı

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /*        
        Garbage collector ile dispose işlemi session açma işlemi herkesde aynı 
        ancak InitializeFactory farklı veritabanına göre kullanıcının belirlemesi ve buraya yollaması gerek
        ISession facotry ile varsa olanı dönüp yoksa factory kurmasını istiyoruz.

         */

    }
}
