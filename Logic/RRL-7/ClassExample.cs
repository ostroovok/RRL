using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClassExample
    {
        public object Class { get; set; }
        public Type ActiveClass { get; set; }
        public List<object> Classes { get; set; }
        public ClassExample(ClassReflection crfl, object[] properties)
        {
            ActiveClass = crfl.ActiveClass;
            object tempClass = Activator.CreateInstance(ActiveClass, properties);
            Class = tempClass;
        }
        public object UseMethod(string methodName, object[] parameters)
        {
            object result = null;
            if (Class != null)
            {
                if (parameters.Length == 0)
                    parameters = null;
                MethodInfo method = ActiveClass.GetMethod(methodName);
                result = method.Invoke(Class, parameters);
            }
            return result;
        }
    }
}
