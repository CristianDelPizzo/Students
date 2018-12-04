using System;
using System.Collections.Generic;
using System.IO;
namespace StudentsSolution
{
    class Program
    {
        public static List<Student> StudentsList = new List<Student>();

        static void Main(string[] args)
        {
            Presentation();
            var reader = new StreamReader(@"C:\Users\crisy\source\repos\Delpy991\Corso\StudentsSolution\StudentsSolution\StudentsSolution\Students.csv");
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    StudentsList.Add(new Student(Convert.ToInt32(values[0]), values[1], values[2], Convert.ToInt32(values[3]), values[4], Convert.ToDouble(values[5])));
                
                }
            }

            
        }

        private static void Presentation()
        {
            Console.WriteLine("Ecco i comandi che puoi eseguire:\n" +
            "Comando l: Lista dei studenti\n" +
            "Comando f: Ricerca per ID Studente\n" +
            "Comando v: Media dei voti\n" +
            "Comando m: Moda dei voti\n" +
            "Comando d: Mediana dei voti");
            var Choice = Console.Read();
            switch(Choice)
            {
                
                case 'l':
                case 'L':
                    Console.WriteLine("Entrato nello switch");
                    //foreach(var Student in StudentsList)
                    //{
                    //    Console.WriteLine("Entrato nel ciclo");
                    //    Console.WriteLine(Student.ToString());
                    //}
                    //for(int i =0;i<StudentsList.Count;i++)
                    //{
                    //    Console.WriteLine("Entrato nel ciclo");
                    //    Console.WriteLine(StudentsList[i].ToString());            
                    //}
                    break;


            }
        }
        private void Add(Student newStudent)
        {
            StudentsList.Add(newStudent);
        }
        
    }
}
