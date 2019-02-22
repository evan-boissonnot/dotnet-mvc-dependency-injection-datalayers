using LesObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces
{
    public interface IProvider
    {
        string DoWhatYouNeedToDo(OneFilter filter);
    }
}
