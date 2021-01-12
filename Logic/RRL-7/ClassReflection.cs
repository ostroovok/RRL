using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClassReflection
    {
        public Type ActiveClass { get; set; }

        public LibraryReflection Rfl { get; set; }

        public ClassReflection(Type activeClassType)
        {
            ActiveClass = activeClassType;
        }
        public ClassReflection(LibraryReflection rfl, string activeClass)
        {
            Rfl = rfl;
            ActiveClass = SetActiveClass(activeClass);
        }
        private Type SetActiveClass(string name)
        {
            foreach (Type t in Rfl.GetTypesInfo())
            {
                if (t.Name == name)
                    return t;
            }
            return null;
        }
        public string[] GetClassMethods()
        {
            List<string> outList = new List<string>();
            foreach (MethodInfo method in ActiveClass.GetMethods())
            {
                if (!method.Name.Contains("get_") && !method.Name.Contains("set_") && method.IsPublic && !method.IsAbstract)
                {
                    outList.Add(method.Name);
                }
            }
            return outList.ToArray();
        }
        public string[] GetAllMethods()
        {
            List<string> outList = new List<string>();
            foreach (MethodInfo method in ActiveClass.GetMethods())
            {
                if (!method.Name.Contains("get_") && !method.Name.Contains("set_") && method.IsPublic)
                {
                    outList.Add(method.Name);
                }
            }
            return outList.ToArray();
        }
        public string[] GetMethodParameters(string name)
        {
            MethodInfo method = ActiveClass.GetMethod(name);
            ParameterInfo[] parameters = method.GetParameters();
            string[] parametersInfo = new string[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                parametersInfo[i] = parameters[i].ParameterType.Name + "." + parameters[i].Name;
            }
            return parametersInfo;
        }
        public PropertyInfo[] GetProperties()
        {
            List<PropertyInfo> outList = new List<PropertyInfo>();
            foreach (PropertyInfo property in ActiveClass.GetProperties())
            {
                outList.Add(property);
            }
            return outList.ToArray();
        }
        public string[] GetPropertiesToString()
        {
            List<string> outList = new List<string>();
            foreach (PropertyInfo property in ActiveClass.GetProperties())
            {
                outList.Add(property.Name + '.' + property.PropertyType.ToString().Split('.')[1]);
            }
            return outList.ToArray();
        }
    }
}
