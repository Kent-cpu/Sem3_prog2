using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab_2
{
    static class XmlHandler
    {
        public static Cars getCars()
        {
            List<Car> carsList = new List<Car>();
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("C:/Users/rusla/Desktop/Лабы/3 семестр/Программирование/Lab_2/Lab_2/XMLCars.xml");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    string id = node.Attributes["id"]?.Value;
                    string model = node["model"]?.InnerText;
                    bool isYear = int.TryParse(node["year"]?.InnerText, out int year);
                    bool isPrice = double.TryParse(node["price"]?.InnerText, out double price);

                    if (id == null || id == "" || model == null || model== "" || !isYear || year <= 0 || !isPrice || price < 0)
                    {
                        return null;
                    }

                    Car car = new Car(id, model, year, price);
                    carsList.Add(car);
                }      
            } catch(Exception e)
            {
                throw e;
            } 

            if(carsList.Count == 0)
            {
                return null;
            }

            Cars cars = new Cars(carsList);
            
            return cars;
        }
    }
}