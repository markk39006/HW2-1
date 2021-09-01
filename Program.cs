using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            user jame = new user("jame");
            jame.name = "jame watson";
            jame.email = "jame@gmail.com";

            address jameaddress = new address();
            jameaddress.street = "131/75 puttamonthon";
            jameaddress.city = "Nakhonpathom";
            jameaddress.zipcode = "10180";

            Tshirt Tshirt1 = new Tshirt("L", "Red", 500, "Red Picture");
            Tshirt Tshirt2 = new Tshirt("M", "Black", 750, "Black Picture");
            Tshirt Tshirt3 = new Tshirt("S", "Yellow", 625, "Yellow Picture");

            jame.addList(Tshirt1);
            jame.addList(Tshirt2);
            jame.addList(Tshirt3);

            jame.getTotalCost();
        }
    }

    class Tshirt
    {
        public string size;
        public string color;
        public float price;
        public string image;

        public Tshirt(string valuesize, string valuecolor, float valueprice, string valueimage)
        {
            size = valuesize;
            color = valuecolor;
            price = valueprice;
            image = valueimage;
        }
    }

    class user
    {
        public string name;
        public string email;
        public List<Tshirt> shoppingcard;

        public user(string valuename)
        {
            name = valuename;
            shoppingcard = new List<Tshirt>();
        }

        public void addList(Tshirt Tshrits)
        {
            shoppingcard.Add(Tshrits);
        }

        public void getTotalCost()
        {
            float sum = 0;
            foreach (Tshirt item in shoppingcard)
            {
                sum = sum + item.price;
            }
            Console.WriteLine("Total cost: " + sum);
        }
    }

    class address
    {
        public string street;
        public string city;
        public string zipcode;

    }

}