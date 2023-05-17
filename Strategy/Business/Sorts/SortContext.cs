using Strategy.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business.Sorts
{
    public class SortContext
    {
        private IStrategy _SortingStrategies;

        private List<string> listItem = new List<string>();

        public SortContext(IStrategy strategy)
        {
            _SortingStrategies = strategy;
        }

        public void Add(List<string> strItem)
        {
            foreach (var item in strItem)
            {
                listItem.Add(item);
            }
        }

        public void Remove(string strItem)
        {
            listItem.Remove(strItem);
        }

        public void Sort()
        {
            _SortingStrategies.Sort(listItem);
        }
    }
}
