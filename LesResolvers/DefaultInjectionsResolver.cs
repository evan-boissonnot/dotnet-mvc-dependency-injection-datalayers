using Autofac;
using LesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesResolvers
{
    public class DefaultInjectionsResolver : IInjectionsResolver
    {
        private IContainer _container = null;

        public DefaultInjectionsResolver(IContainer container)
        {
            this._container = container;
        }

        public T Resolve<T>(T item)
        {
            throw new NotImplementedException();
        }
    }
}
