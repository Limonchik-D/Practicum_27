using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_PR_27;

namespace Task_2_pr_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация массива объектов Car
            Car[] car = new Car[]
            {
                new Car("BMW", "X5", 2020),
                new Car("BMW", "X4", 2010),
                new Car("BMW", "X3", 2000)
            };

            Console.WriteLine("Инициализированный массив:");
            foreach (var cars in car)
            {
                Console.WriteLine(cars.ToString());
            }

            // Заполнение массива с клавиатуры
            Car[] car1 = new Car[3];
            for (int i = 0; i < car1.Length; i++)
            {
                Console.WriteLine("Введите марку автомобиля:");
                string make = Console.ReadLine();

                Console.WriteLine("Введите модель автомобиля:");
                string model = Console.ReadLine();

                Console.WriteLine("Введите год производства:");
                int year;
                while (!int.TryParse(Console.ReadLine(), out year)) // Проверка ввода года
                {
                    Console.WriteLine("Ошибка! Введите корректный год:");
                }

                car1[i] = new Car(make, model, year); // Сохранение объекта в массив
            }

 
            Console.WriteLine("\nМассив, заполненный с клавиатуры:");
            foreach (var cars in car1)
            {
                Console.WriteLine(cars.ToString());
            }

            Console.ReadKey(); // Ожидание нажатия клавиши перед завершением
        }
    
    }
}
