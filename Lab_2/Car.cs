using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Car
    {
        public string id { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Car(string id, string model, int year, double price)
        {
            this.id = id;
            this.model = model;
            this.year = year;
            this.price = price;
        }
    }
}
