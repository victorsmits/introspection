using System;
using System.CodeDom;
using System.Reflection;

namespace introspection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CodeSource("Item");
        }

        public static void CodeSource(Object classe)
        {
            Type type = classe.GetType();
            Console.WriteLine(type);
        }
    }
}