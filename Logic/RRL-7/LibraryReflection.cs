using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LibraryReflection
    {
        public string Path { get; set; }
        public string InterfaceName { get; set; }

        public LibraryReflection(string path, string interfaceName)
        {
            Path = path;
            InterfaceName = interfaceName;
        }
        public List<Type> GetTypesInfo()
        {
            Type[] types = Assembly.LoadFrom(Path).GetTypes();
            List<Type> outList = new List<Type>();
            foreach(Type t in types)
            {
                if(!t.IsAbstract && t.GetInterface(Type.GetType($"{Path.Split('.')[0]}.{InterfaceName}", true,true).Name) != null)
                {
                    outList.Add(t);
                }
            }
            return outList;
        }
        public PropertyInfo[] GetProperties(Type type)
        {
            List<PropertyInfo> outList = new List<PropertyInfo>();
            foreach (PropertyInfo property in type.GetProperties())
            {
                outList.Add(property);
            }
            return outList.ToArray();
        }
        public List<string> GetMethods(Type type)
        {
            List<string> outList = new List<string>();
            foreach (MethodInfo method in type.GetMethods())
            {
                if (!method.Name.Contains("get_") && !method.Name.Contains("set_") && method.IsPublic && !method.IsAbstract)
                {
                    outList.Add(method.Name);
                }
            }
            return outList;
        }
        public List<string> ClassesList() 
        {
            List<Type> types = GetTypesInfo();
            List<string> outList = new List<string>();
            foreach(Type t in types)
            {
                outList.Add(t.Name);
            }
            return outList;
        }
    }
}
