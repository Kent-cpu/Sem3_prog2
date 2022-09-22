using System;
using System.Collections.Generic;


namespace Lab_2
{
    class Cars
    {
        public List<Car> listCars { get; set; }

        public Cars() {}

        public Cars(List<Car> listCars)
        {
            this.listCars = listCars;
        }

        public void print(System.Windows.Forms.DataGridView view)
        {
            view.Rows.Clear();
            foreach (Car car in listCars)
            {
                int rowNumber = view.Rows.Add();
                view.Rows[rowNumber].Cells["id_column"].Value = car.id;
                view.Rows[rowNumber].Cells["model_column"].Value = car.model;
                view.Rows[rowNumber].Cells["year_column"].Value = car.year.ToString();
                view.Rows[rowNumber].Cells["price_column"].Value = car.price.ToString();
            } 
        }
    }
}
