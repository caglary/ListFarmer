using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace StaticClass
{
    public static class Reflection
    {
        public static List<string> ClassOfApplication(string namespaceName)
        {
            List<string> ClassOfApplicationList = new List<string>();
            Assembly assembly = Assembly.Load(namespaceName);
            Type[] _classType = assembly.GetTypes();
            for (int i = 0; i < _classType.Length; i++)
            {
                ClassOfApplicationList.Add(_classType[i].Name);
            }
            return ClassOfApplicationList;
        }
        public static List<string> MethodsOfClass(string namespaceName, string className)
        {
            List<string> MethodOfClassList = new List<string>();
            Assembly assembly = Assembly.Load(namespaceName);
            Type[] _classType= assembly.GetTypes();
            if (_classType == null) return MethodOfClassList;
            for (int i = 0; i < _classType.Length; i++)
            {
                if(_classType[i].Name==className)
                {
                    MethodInfo[] methodList = _classType[i].GetMethods();
                    for (int x = 0; x < methodList.Length; x++)
                    {
                        MethodOfClassList.Add(methodList[x].Name);
                    }
                }
            }
          
            return MethodOfClassList;
        }
        public static List<string> ParametersofMethod(string namespaceName, string className,string methodName)
        {
            List<string> ParametersofMethod = new List<string>();
            Assembly assembly = Assembly.Load(namespaceName);
            Type[] _classType = assembly.GetTypes();
            if (_classType == null) return ParametersofMethod;
            for (int i = 0; i < _classType.Length; i++)
            {
                if (_classType[i].Name == className)
                {
                    MethodInfo[] methodList = _classType[i].GetMethods();
                    for (int a = 0; a < methodList.Length; a++)
                    {
                        if (methodList[a].Name == methodName)
                        {
                            
                            ParameterInfo[] parametreler= methodList[a].GetParameters();
                            for (int z = 0; z < parametreler.Length; z++)
                            {
                                ParametersofMethod.Add(parametreler[z].Name+" "+parametreler[z].ParameterType);
                            }
                        }
                        
                    }
                }
            }
            return ParametersofMethod;
        }
    }
}
