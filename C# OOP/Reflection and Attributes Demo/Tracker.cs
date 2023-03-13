using System;
using System.Reflection;

namespace AttrbiutesAndReflection
{
    public class Tracker
    {
        public void PrintMethodsByAuthor(string name)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                foreach (var method in type.GetMethods(
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.Static))
                {
                    var attr = method.GetCustomAttribute<AuthorAttribute>();
                    if (attr != null && attr.Name == name)
                    {
                        Console.WriteLine(method.Name);
                    }
                }
            }
        }
    }
}