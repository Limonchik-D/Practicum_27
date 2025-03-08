using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_PR_27
{
    class Car //Описание автомобиля
    {
        string make; //Марка автомобиля
        string model; //Модель автомобиля
        int year; //Год выпуска автомобиля

        //Свойства для доступа к полям
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        //Конструкторы
        public Car()
        {
            make = "Toyota";
            model = "Corolla";
            year = 2010;
        }

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        //Метод для вывода информации об автомобиле
        public override string ToString()
        {
            return $"Марка: {Make}, Модеь: {Model}, Год выпуска: {Year}";
        }


    }
}
