using SteelGymDesktop.Applications.Interfaces;
using SteelGymDesktop.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace SteelGymDesktop.Applications
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _servicebase;

        public AppServiceBase(IServiceBase<TEntity> servicebase)
        {
            _servicebase = servicebase;
        }

        public void Add(TEntity obj)
        {
            _servicebase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _servicebase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _servicebase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _servicebase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _servicebase.Remove(obj);
        }

        public void Dispose()
        {
            _servicebase.Dispose();
        }
    }
}
