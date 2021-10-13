using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyserProgram
{
    class Reflections
    {
        /// <summary>
        /// method to get the metadata of thr MoodAnalyser
        /// </summary>
        public void ReflectionTests()
        {
            Type t = typeof(MoodAnalyser);

            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Class Name : {0}", t.Name);

            Console.WriteLine("Contructor Informations : ");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            Console.WriteLine("Methods Informations : ");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
        }
    }
}
