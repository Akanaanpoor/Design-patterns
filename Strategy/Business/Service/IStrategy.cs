using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business.Service
{
    public interface IStrategy
    {
         void Sort(List<string> listItem);
    }
}
