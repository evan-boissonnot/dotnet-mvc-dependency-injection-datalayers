using LesObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces
{
    public interface IDalFactory
    {
        IDal GetOne(OneFilter filter);
    }
}
