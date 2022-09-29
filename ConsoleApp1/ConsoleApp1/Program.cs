using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> myStudent = new List<Student>();

            void Menu()
            {
                Console.WriteLine("1)Автоматически внести данные");
                Console.WriteLine("2)Внести данные с терминала");
                Console.WriteLine("3)вывод информации о студентах");
                Console.WriteLine("4)Удаление студента");
                Console.WriteLine("5)Выход");
            }
            string input;
            do
            {
                Console.WriteLine("Выберите пункт меню");
                Menu();
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Вы выбрали 1 пункт");
                    Student student = new Student();
                    student.InputData();
                    myStudent.Add(student);
                }
                else if (input == "2")
                {
                    Console.WriteLine("Вы выбрали 2 пункт");
                    Student student = new Student();
                    student.InputDataByConsole();
                    myStudent.Add(student);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Вы выбрали 3 пункт");
                    foreach (var item in myStudent)
                    {
                        item.OutputData();
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Вы выбрали 4 пункт");
                    Console.WriteLine("Укажите номер зачетной книжки");
                    int book = Convert.ToInt32(Console.ReadLine());
                    var i = 0;
                    var deleteStudentIndex = -999;
                    foreach (var el in myStudent)
                    {
                        if (el.numberOfBook == book)
                        {
                            deleteStudentIndex = i;
                        }
                        i++;
                    }
                    if (deleteStudentIndex != -999)
                    {
                        myStudent.RemoveAt(deleteStudentIndex);
                    }
                    else
                    {
                        Console.WriteLine("Такого студента не существует");
                    }
                }

            }
            while (input != "5");
        }
    }
}