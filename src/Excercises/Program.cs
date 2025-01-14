﻿using System.Reflection;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region BaseProj

            //var types = Assembly.GetExecutingAssembly()
            //    .GetTypes()
            //    .Where(t => t.BaseType == typeof(BaseProj))
            //    .OrderBy(t => t.Name);
            //Dictionary<int, BaseProj> projects = new();
            //int i = 0;

            //foreach (var type in types)
            //{
            //    var instance = (BaseProj)Activator.CreateInstance(type);
            //    Console.WriteLine($"ID {i}: {instance.Description}");

            //    projects.Add(i++, instance);
            //}

            #endregion
            #region BaseAlgorithmProj
            //var types = Assembly.GetExecutingAssembly()
            //   .GetTypes()
            //   .Where(t => t.BaseType == typeof(BaseAlgorithmProj))
            //   .OrderBy(t => t.Name);
            //Dictionary<int, BaseAlgorithmProj> projects = new();
            //int i = 0;

            //foreach (var type in types)
            //{
            //    var instance = (BaseAlgorithmProj)Activator.CreateInstance(type);
            //    Console.WriteLine($"ID {i}: {instance.Description}");

            //    projects.Add(i++, instance);
            //}
            #endregion
            #region ExceptionHandlingProj
            //var types = Assembly.GetExecutingAssembly()
            //   .GetTypes()
            //   .Where(t => t.BaseType == typeof(ExceptionHandlingProj))
            //   .OrderBy(t => t.Name);
            //Dictionary<int, ExceptionHandlingProj> projects = new();
            //int i = 0;

            //foreach (var type in types)
            //{
            //    var instance = (ExceptionHandlingProj)Activator.CreateInstance(type);
            //    Console.WriteLine($"ID {i}: {instance.Description}");

            //    projects.Add(i++, instance);
            //}
            #endregion
            #region DataTypesProj
            //var types = Assembly.GetExecutingAssembly()
            //   .GetTypes()
            //   .Where(t => t.BaseType == typeof(DataTypesProj))
            //   .OrderBy(t => t.Name);
            //Dictionary<int, DataTypesProj> projects = new();
            //int i = 0;

            //foreach (var type in types)
            //{
            //    var instance = (DataTypesProj)Activator.CreateInstance(type);
            //    Console.WriteLine($"ID {i}: {instance.Description}");

            //    projects.Add(i++, instance);
            //}
            #endregion
            #region ObjectOrientedProgrammingProj
            var types = Assembly.GetExecutingAssembly()
               .GetTypes()
               .Where(t => t.BaseType == typeof(ObjectOrientedProgrammingProj))
               .OrderBy(t => t.Name);
            Dictionary<int, ObjectOrientedProgrammingProj> projects = new();
            int i = 0;

            foreach (var type in types)
            {
                var instance = (ObjectOrientedProgrammingProj)Activator.CreateInstance(type);
                Console.WriteLine($"ID {i}: {instance.Description}");

                projects.Add(i++, instance);
            }
            #endregion




            ///////////////////////
            var cont = true;
            do
            {
                int id = 0;
                do
                {
                    Console.Write("Enter ID: ");
                    if (int.TryParse(Console.ReadLine(), out id))
                    {
                        if (projects.ContainsKey(id))
                        {
                            break;
                        }

                        Console.WriteLine($"No item found by ID {id}. Try again!");
                    }
                } while (true);

                var project = projects[id];

                try
                {
                    Console.WriteLine($"---------------------");
                    Console.WriteLine(project.Description);
                    Console.WriteLine($"---------------------");
                    project.Run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something happen while running solution for {project.Description}: {ex.Message}");
                }

                Console.Write("Continue (y/n)?: ");
                cont = Console.ReadLine() == "y";
            } while (cont);
        }
    }
}
