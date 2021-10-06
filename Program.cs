using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            RestorantMenu menu = new RestorantMenu();
            Restorants RestorantList = new Restorants();
            RestorantList.Name = "Katsu";
            RestorantList.Location = "Khagani str. 25B ,AZ1022 Baku";
            RestorantList.OpenorClosed = "12.00-23.00";
            RestorantList.MinimumOrder = 6.00;
            RestorantList.Number = +994124938170;
            RestorantList.menu = menu.Detail(RestorantList.Name);

            Restorants RestorantList2 = new Restorants();
            RestorantList2.Name = "Bella Pizza";
            RestorantList2.Location = "61 A, Samad Vurgun st , AZ1000 Baku";
            RestorantList2.OpenorClosed = "11.00–23.00";
            RestorantList2.MinimumOrder = 6.00;
            RestorantList2.Number = +994124938621;
            RestorantList2.menu = menu.Detail(RestorantList2.Name);

            Restorants RestorantList3 = new Restorants();
            RestorantList3.Name = "FryChicken";
            RestorantList3.Location = "Yusif Mammadaliyev, 25D ,AZ1000 Baku";
            RestorantList3.OpenorClosed = "12.00–03.00";
            RestorantList3.MinimumOrder = 6.00;
            RestorantList3.Number = +994518884888;
            RestorantList3.menu = menu.Detail(RestorantList3.Name);

            string[] arr =
{
            "Restoran Adi: " +   RestorantList.Name,
            "Ünvan:  " + RestorantList.Location,
            "Açıq olan vaxtlar:  " +  RestorantList.OpenorClosed,
            "MİN. SİFARİŞ:  " + RestorantList.MinimumOrder,
            "Elaqe:  " + RestorantList.Number,
            "Menu:  "  + RestorantList.menu,
            "Restoran Adi: " +   RestorantList2.Name,
            "Ünvan:  " + RestorantList2.Location,
            "Açıq olan vaxtlar:  " +  RestorantList2.OpenorClosed,
            "MİN. SİFARİŞ:  " + RestorantList2.MinimumOrder,
            "Elaqe:  " + RestorantList2.Number,
            "Menu:  "  + RestorantList2.menu,
            "Restoran Adi: " +   RestorantList3.Name,
            "Ünvan:  " + RestorantList3.Location,
            "Açıq olan vaxtlar:  " +  RestorantList3.OpenorClosed,
            "MİN. SİFARİŞ:  " + RestorantList3.MinimumOrder,
            "Elaqe:  " + RestorantList3.Number,
            "Menu:  "  + RestorantList3.menu,
            };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if (i == 5 || i == 11)
                {
                    Console.WriteLine();
                }

            }

        }

       

    }
}
