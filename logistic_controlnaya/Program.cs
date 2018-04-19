using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic_controlnaya
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем маркеры
            Marker marker1 = new Marker() { Name = "Astana", CoordX = 100, CoordY = 100 };
            Marker marker2 = new Marker() { Name = "Karaganda", CoordX = 150, CoordY = 100 };
            Marker marker3 = new Marker() { Name = "Semey", CoordX = 250, CoordY = 50 };
            Marker marker4 = new Marker() { Name = "Taraz", CoordX = 250, CoordY = 50 };
            Marker marker5 = new Marker() { Name = "Almaty", CoordX = 50, CoordY = 50 };

            //создаем маршруты
            List<Marker> list1 = new List<Marker>();
            list1.AddRange(new Marker[] { marker1, marker2, marker5 });
            Route route1 = new Route() { Points = list1};

            List<Marker> list2 = new List<Marker>();
            list2.AddRange(new Marker[] { marker1, marker3, marker5 });
            Route route2 = new Route() { Points = list2 };

            List<Marker> list3 = new List<Marker>();
            list3.AddRange(new Marker[] { marker1, marker4, marker5 });
            Route route3 = new Route() { Points = list3 };

            //карта
            Map map = new Map();
            map.AddMarker(marker1);
            map.AddMarker(marker2);
            map.AddMarker(marker3);
            map.AddMarker(marker4);
            map.AddMarker(marker5);

            map.AddRoute(route1);
            map.AddRoute(route2);
            map.AddRoute(route3);

            //Entity Framework
            using(Context context = new Context())
            {
                //City
                City city1 = new City() { Id = 1, Name = "Astana" };
                City city2 = new City() { Id = 2, Name = "Almaty" };
                City city3 = new City() { Id = 3, Name = "Karaganda" };
                context.Cities.Add(city1);
                context.Cities.Add(city2);
                context.Cities.Add(city3);

                //Companies
                Companies company1 = new Companies() { Id = 1, Name = "Company1", CityId = 1, Info = "non logistic" };
                Companies company2 = new Companies() { Id = 2, Name = "Company2", CityId = 2, Info = "non logistic" };
                Companies company3 = new Companies() { Id = 3, Name = "Company3", CityId = 3, Info = "logistic" };
                context.Companies.Add(company1);
                context.Companies.Add(company2);
                context.Companies.Add(company3);

                //Cars
                Cars car1 = new Cars() { Id = 1, Name = "Car1", Type = "little" };
                Cars car2 = new Cars() { Id = 2, Name = "Car2", Type = "big" };
                context.Cars.Add(car1);
                context.Cars.Add(car2);

                //Goods
                Good good1 = new Good() { Id = 1, Name = "good1", Weight = 50 };
                Good good2 = new Good() { Id = 2, Name = "good2", Weight = 150 };
                context.Goods.Add(good1);
                context.Goods.Add(good2);

                //Orders
                Order order1 = new Order() { Id = 1, SenderId = 1, RecieverId = 2, LogisticCompId = 3, CarId = 1, GoodsId = 1, DepartureDate = new DateTime(2018, 4, 20, 18, 00, 00), RecievingDate = new DateTime(2018, 4, 21, 18, 00, 00), Info = "some info" };
                context.Orders.Add(order1);
                //order1.ShowDetails();

                context.SaveChanges();

                var orders = (from order in context.Orders
                              select order).ToList();

                foreach (var item in orders)
                {
                    item.ShowDetails();
                    Console.WriteLine("\n\n");
                }
            }
        }
    }
}
