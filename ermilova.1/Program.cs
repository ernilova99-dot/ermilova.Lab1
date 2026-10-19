using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ermilova._1
{
    internal class Program
    {
      
    // Описание класса Student (Студент)
    class Student
        {
            // Открытые поля для хранения ФИО и двух оценок
            public string fio;
            public int ocenka1;
            public int ocenka2;

            // Метод - показать на экране данные о студенте
            public void Show()
            {
                Console.WriteLine($"Студент: {fio}, Оценка 1: {ocenka1}, Оценка 2: {ocenka2}");
            }

            // Метод - подсчет средней оценки студента
            public float SredOcenka()
            {
                // Приводим к float, чтобы деление было дробным (например, 4.0, а не 4)
                return (ocenka1 + ocenka2) / 2.0f;
            }
        }
    

       
        
            public static void Main()
            {
                // 1. Создаем первый объект класса Student
                Student student1 = new Student();

                // 2. Задаем значения (как в задании)
                student1.fio = "Иванов";
                student1.ocenka1 = 3;
                student1.ocenka2 = 5;

                // Создаем второй объект (поскольку в задании сказано "объектов")
                Student student2 = new Student();
                student2.fio = "Петров";
                student2.ocenka1 = 4;
                student2.ocenka2 = 4;

                // 3. Выводим на экран данные, хранящиеся в объектах
                student1.Show();
                // 4. Рассчитываем и выводим среднюю оценку
                Console.WriteLine($"Средняя оценка: {student1.SredOcenka()}\n");

                student2.Show();
                Console.WriteLine($"Средняя оценка: {student2.SredOcenka()}\n");

                // Задержка экрана
                Console.ReadKey();
            }
        }
    }


