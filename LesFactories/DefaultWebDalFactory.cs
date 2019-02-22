using LesDataLayers;
using LesInterfaces;
using LesObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LesFactories
{
    public class DefaultWebDalFactory : IDalFactory
    {
        public DefaultWebDalFactory()
        {
            
        }

        public IDal GetOne(OneFilter filter)
        {
            IDal dal = null;

            if (filter.Value1 == "1")
                dal = DependencyResolver.Current.GetService<Dal1>();
            else
                dal = DependencyResolver.Current.GetService<Dal2>();

            return dal;
        }
    }
}
