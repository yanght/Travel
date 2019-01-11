using Autofac;
using Autofac.Extras.DynamicProxy;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Travel.Domain;
using Travel.Domain.Models;
using Travel.Service.IService;
using Travel.Service.Service;

namespace Travel.Site.IocContainer
{
    public class ServiceRegister : IDependencyRegistrar
    {
        public int Order
        {
            get
            {
                return 0;
            }
        }

        public void Register(ContainerBuilder builder, List<Type> listType)
        {
            builder.Register(c => new SqlServerDbContext("server=116.62.208.130;database=Travel; User ID=sa;Password=yannis_123@live.com")).As<IDbContext>();
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
        }
    }
}
