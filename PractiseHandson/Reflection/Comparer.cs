using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ObjectComparer
{
    public class Comparer
    {
        
        Type T1 = Type.GetType("ObjectComparer.Employee");
        Type T2 = Type.GetType("ObjectComparer.Student");
        public bool typeComapare()
        {
            if (T1 == T2)
            {
                return true;
            }
            else
                return false;
        }
        public bool methodComapare()
        {
            
            MethodInfo[] method1 = T1.GetMethods();
            MethodInfo[] method2 = T2.GetMethods();
            if (method1 == method2)
            {
                return true;
            }
            else
                return false;

        }
        public bool propertyComapare()
        {
            PropertyInfo[] property1 = T1.GetProperties();
            PropertyInfo[] property2 = T1.GetProperties();
            if (property1 == property2)
            {
                return true;
            }
            else
                return false;
        }
    }
}
