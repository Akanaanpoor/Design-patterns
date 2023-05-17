using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.Handler
{
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetNext(IHandler<T> next);
        void Handle(T request);
    }
}
