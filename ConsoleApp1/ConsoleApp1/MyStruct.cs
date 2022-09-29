using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLesson
{
    struct Student
    {
        public string name;
        public string lastname;
        public string sex;
        public byte age;
        public byte course;
        public int numberOfBook;
        public string educationalFormat;
        public void InputData()
        {
            name = "Владислав";
            lastname = "Орлов";
            sex = "Male";
            age = 17;
            course = 2;
            numberOfBook = 225347;
            educationalFormat = "Commerce education";
        }
        public void InputDataByConsole()
        {
            Console.WriteLine("Введите имя студента");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию студента");
            lastname = Console.ReadLine();
            Console.WriteLine("Укажите пол студена");
            sex = Console.ReadLine();
            Console.WriteLine("Укажите возраст студента");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("На каком курсе учится студент?");
            course = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер зачетной книжки");
            numberOfBook = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите формат зачетной книжки");
            educationalFormat = Console.ReadLine();
        }
        public void OutputData()
        {
            Console.WriteLine(name);
            Console.WriteLine(lastname);
            Console.WriteLine(sex);
            Console.WriteLine(age);
            Console.WriteLine(course);
            Console.WriteLine(numberOfBook);
            Console.WriteLine(educationalFormat);
        }
    }
}
