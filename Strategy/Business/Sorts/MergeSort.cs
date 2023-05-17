﻿using Strategy.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Business.Sorts
{
    public class MergeSort : IStrategy
    {
        public void Sort(List<string> listItem)
        {
            Console.WriteLine("\r\nMerge Sorting ...");
        }
    }
}
