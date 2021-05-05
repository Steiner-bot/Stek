using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Задание
{
    public class MyComp : IComparer<KeyVal>
    {
        public int Compare(KeyVal l, KeyVal r)
        {
            return l.y < r.y ? -1 : 1;
        }
    }
}
