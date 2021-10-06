using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class RestorantMenu
    {
        public string Detail(string menu)
        {
           
            string Katsu =$"Arigato Set  , Katsu Set, Kyoto Set ," +
                $"\n Tokyo Hot Set , Black Dragon Roll ,\n Hot Unagi Kabayaki";

            string BellaPizza = $"Polo Fungi Kombo   , Panini Kombo, Kyoto Set ," +
                $"\n Mosaica + 2 Baltika® Hədiyyə, Black Dragon Roll ,\n Hot Unagi Kabayaki";


            string FryChicken = $"Sando Kombo   , Don Pablo Kombo, Toyuq Sando Wrap ," +
                $"\n Bird Box, Sweet Chilli Sando ,\n El Profesor";


            switch (menu)
            {
                case "Katsu":
                    menu = Katsu;
                    break;

                case "Bella Pizza":
                    menu = BellaPizza;
                    break;

                case "FryChicken":
                    menu = FryChicken;
                    break;
            }
            return menu;
        }

    }
    
       
}
