using LesInterfaces;
using LesObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProviders
{
    public class UnProvider : IProvider
    {
        private IDalFactory _dalFactory = null;

        public UnProvider(IDalFactory dalFactory)
        {
            this._dalFactory = dalFactory;
        }

        public string DoWhatYouNeedToDo(OneFilter filter)
        {
            return this._dalFactory.GetOne(filter).SayAlelouia();
        }
    }
}
