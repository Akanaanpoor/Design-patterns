using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Business.Handler
{
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private IHandler<T> Next { get; set; }

        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }

}
