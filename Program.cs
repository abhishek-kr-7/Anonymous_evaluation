using System;
using System.Dynamic;

namespace Anonymous
{
    public class Product
    {
        private string? _color;
        private float _price;
        private int _count;

        public string? Color { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var v = new { Amount = 108, Message = "Hello" };

            Console.WriteLine(v.Amount + v.Message);

            Product p1 = new Product();
            p1.Color = "Blue";
            p1.Price = 89.5f;
            p1.Count = 100;

            // var productQuery =
            //     from prod in Product;
            //     select new { prod.Color, prod.Price };

            var productQuery = new { Color = p1.Color, Price = p1.Price };

            System.Console.WriteLine(productQuery.Color);

            // foreach (var v in productQuery)
            // {
            //     Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
            // }

            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            Console.WriteLine(onSale);

            var Details = new { Name = "Abhishek", age = 21, loc = new { home = "Bihar", curent = "Kolkata" } };
            System.Console.WriteLine(Details);
            System.Console.WriteLine(Details.loc.curent);

            var anArray = new[] {
                new {CName = "Abhishek",Loc = "Gaya"},
                new {CName = "Disha", Loc = "Kolkata"},
                new {CName = "Aishik", Loc = "Howrah"},
                new {CName = "Ujjwal", Loc = "Bankura"},

            };

            foreach (var item in anArray)
            {
                System.Console.WriteLine(item.Loc);
            }


            //ExpandoObject
            dynamic person = new ExpandoObject(); 
            person.FisrtName = "Abhishek"; 
            person.Age = 32; 
            System.Console.WriteLine("{0} is {1} years old", person.FisrtName, person.Age);

            // person.Address = "Bengal";            
            person.Address = new ExpandoObject();
            person.Address.City = "Kokata";
            person.Address.Country = "India";

            // System.Console.WriteLine(person.Address);            
            System.Console.WriteLine(person.Address.City);
            System.Console.WriteLine(person.Address.Country);

            //Dynamic method using action delegate and ExpandoObject
            person.SayHello = new Action(() => {System.Console.WriteLine("Hello");});
            person.SayHello();

        }
    }
}