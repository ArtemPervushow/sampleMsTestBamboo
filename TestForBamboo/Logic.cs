using System;
using System.Collections.Generic;
using System.Text;

namespace TestForBamboo
{
    public class Logic
    {
        public Boolean aIsa(Object a)
        {
            return a == a && a.Equals(a);
        }

        public Boolean chainOnEquality(Object a, Object b, Object c)
        {
            if(a.Equals(b) && b.Equals(c))
            {
                return a.Equals(c);
            }
            return false;
        }

        public Boolean aIsB(Object a, Object b)
        {
            return a.Equals(b) == b.Equals(a); 
        }
    }
}
