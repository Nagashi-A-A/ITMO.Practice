using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска


        private double cust;
        private bool returnSrok;

        private static double price = 3;

        static Magazine()       //статический конструктор
        {
            price = 20;
        }

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

       public Magazine()
       {
        
       }

       //public override void Show()
       //{
       //    Console.WriteLine("\nЖурнал:\n Том: {0}\n Номер: {1}\n Название: {2}\n Год выпуска: {3}", volume, number, title, year);
       //    base.Show();
       //}

       public override void Return()    // операция "вернуть"
       {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

        // реализация интерфейса

      public bool IfSubs { get; set; }

       public void Subs()
       {
           Console.WriteLine("Подписка на журнал \"{0}\": {1}." , title, IfSubs);
       }

        public static void SetPrice(double price)
        {
            Magazine.price = price;
        }

        public override string ToString()
        {
            if (this.IsAvailable())
                return "\nMagazine:\n Tome: " + volume + "\n Title: " + title +
                "\n Year: " + year + ". " + "\n Price: " + Magazine.price + " p.\n" + base.ToString()
                + "\nTotal Cost: " + cust + " p.";
            else
                return "\nMagazine:\n Tome: " + volume + "\n Title: " + title +
            "\n Year: " + year + ". " + "\n Price: " + Magazine.price + " p.\n" + base.ToString();

        }

        public void PriceMag(int s)
        {

            if (this.returnSrok == true)
                this.cust = s * price;
            else this.cust = s * (price + price * 0.11); ;

        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }
    }
}
