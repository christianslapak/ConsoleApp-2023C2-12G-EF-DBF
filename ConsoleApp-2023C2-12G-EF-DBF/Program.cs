using ConsoleApp_2023C2_12G_EF_DBF.Modelo;
using System;
using System.Linq;

namespace ConsoleApp_2023C2_12G_EF_DBF
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolDBContext();

            var misCursos = context.Course.ToList();

            foreach (var item in misCursos)
            {
                Console.WriteLine("Nombre curso:" + item.CourseName + " Id:" + item.CourseId);
            }

            Console.ReadKey();
        }
    }
}
