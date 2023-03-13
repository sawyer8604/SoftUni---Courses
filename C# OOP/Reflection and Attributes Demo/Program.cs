using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace AttrbiutesAndReflection
{
    [Flags]
    public enum Weekday : int
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
    }
    // can be converted to XML
    [Obsolete]
    [Author("Niki")]
    class Program
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        [Author("Niki")]
        public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [Author("Niki")]
        public static extern int MoveCursor(int x, int y);

        [Author("Stoyan")]
        static void Main(string[] args)
        {
            Weekday lectures = Weekday.Tuesday | Weekday.Friday;
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor("Stoyan");
        }

        [Author("Niki")]
        public static void MoveMouse()
        {
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                MoveCursor(r.Next(0, 1000), r.Next(0, 1000));
                Thread.Sleep(100);
            }
        }

        // Author: Niki
        // Test
        [Author("Stoyan")]
        public static void TestReflectionPerformance()
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1_000_000; i++)
            {
                var person = new Person();
                person.Eat("Orange1");
            }

            Console.WriteLine(sw.Elapsed);
            sw.Restart();

            for (int i = 0; i < 1_000_000; i++)
            {
                Type personType = Type.GetType("AttrbiutesAndReflection.Person");
                var instance = Activator.CreateInstance(personType);
                var method = personType.GetMethod("Eat");
                method.Invoke(instance, new object[] { "Orange2" });
            }

            Console.WriteLine(sw.Elapsed);
        }

        // Comment
        [Author("Stoyan")]
        public void TestReflection()
        {
            var person = new Person();
            person.Eat("Orange");

            string typeName = "AttrbiutesAndReflection.Person";
            Type type = typeof(Person);
            Type type2 = Type.GetType(typeName);
            Type type3 = person.GetType();


            Console.WriteLine(type3.FullName);
            Console.WriteLine(type3.GetProperties().Count());

            var person2 = Activator.CreateInstance(type3, "Niki", "Kostov") as Person;
            var person3 = type3.GetConstructor(
                new Type[2] { typeof(string), typeof(string) }).Invoke(new object[] { "Niki", "Kostov" });
            person2.Eat("Meat");


            Console.WriteLine(new string('-', 60));
            FieldInfo field = type2.GetField("talkContents",
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.Static);
            field.SetValue(person, "CHANGED!!!");
            Console.WriteLine(field.GetValue(person));

            // person.Walk();



            MethodInfo[] methods = person.GetType().GetMethods(
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name + " " + method.GetParameters().Count());
                foreach (ParameterInfo param in method.GetParameters())
                {
                    Console.WriteLine($"    - {param.ParameterType.Name} {param.Name}");
                }
            }
        }

        [Author("Stoyan")]
        public void PrintAllClasses()
        {
            Console.WriteLine(new string('-', 60));
            Assembly assembly = typeof(Dictionary<string, string>).Assembly;
            Console.WriteLine($"Types in {assembly.GetName().Name}: {assembly.GetTypes().Count()}");
            foreach (var typeInfo in assembly.GetTypes())
            {
                if (typeInfo.IsAbstract && typeInfo.IsSealed)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.WriteLine(typeInfo.FullName + " : " + typeInfo.IsAbstract);
                // foreach (var method in typeInfo.GetMethods())
                // {
                //     Console.WriteLine($"    - {method.Name}");
                // }
            }
            Console.ResetColor();

            Console.WriteLine(new string('-', 60));
        }
    }
}
