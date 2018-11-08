using System;
using System.CodeDom;
using System.Reflection;

namespace introspection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CodeSource("introspection.Item");
        }

        public static void CodeSource(string classe)
        {
            BindingFlags flag = BindingFlags.DeclaredOnly |
                                BindingFlags.Public |
                                BindingFlags.NonPublic |
                                BindingFlags.Instance;

            Type type = Type.GetType(classe);

            Console.WriteLine("----MethodInfo----\n");
            foreach (MethodInfo Minfo in type.GetMethods(flag))
            {
                Console.WriteLine(Minfo.Name);
            }

            Console.WriteLine("\n----FieldInfo----\n");
            foreach (FieldInfo Finfo in type.GetFields(flag))
            {
                Console.WriteLine(Finfo);
            }

            Console.WriteLine("\n----PropertyInfo----\n");
            foreach (PropertyInfo Pinfo in type.GetProperties(flag))
            {
                Console.WriteLine(Pinfo);
            }

            Console.WriteLine("\n----ConstructorInfo----\n");
            foreach (ConstructorInfo Cinfo in type.GetConstructors())
            {
                Console.WriteLine(Cinfo);
            }
        }
    }
}