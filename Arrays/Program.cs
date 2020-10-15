using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            #region
            //int a = 10;
            //int b = a;
            //b = 55;
            //foreach (int item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Array 1 = original");




            //int[] array2 = array1;

            //array2[2] = 9999;                       

            //foreach (var item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Array 2 = changed valu in index 2");



            //foreach (int item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Array 1");

            //Console.WriteLine("Array 1 changed because array 2 changed");
            #endregion  arrays
            #region  arrays clonen

            //int[] array1 = { 5, 15, 3, 55 };


            //int[] array2 = (int[])array1.Clone();

            //array2[2] = 9999;

            //foreach  (int item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("***********************************");

            //foreach (int item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region arrays sorteren

            //int[] array1 = { 5, 15, 3, 55 };


            //int[] array2 = (int[])array1.Clone();

            //Array.Sort(array1);

            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Resize(ref array1, 2);
            //Console.WriteLine("after resize");

            //Console.WriteLine("***********************************");


            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Binarysearch  en Sort        (dit is multidimensarrays (maak niet meer dan 2 tabellen)

            int[] validValues = { 101, 102, 300, 301, 600, 255, 400, 9 };
            Console.WriteLine("Enter a number to be searched please");
            int orderNumber = int.Parse(Console.ReadLine());
            Array.Sort(validValues);                                       //ALTIJD .SORT   EN DAN PAS  .BINARYSEARCH
            int answer = Array.BinarySearch(validValues, orderNumber);     // zal de groep validvalues in 2 delen(links vb kleinste getallen, recht grootste getallen)
            bool itemInStock = false;                                      //(zo kan er sneller iets terug gevonden worden in geval van hele grote verzamelingen) eventueel in nog meerdere groepen
            int position = 0;                                             // BIJ BINARYSEARCH wordt volgorde verandert en dus ook adres en KAN JE GEEN FYSIEKE POSITIE meer vragen (om snelheid en fysiek adres te weten worden datababes gebruikt)


            for (int i = 0; i < validValues.Length ; i++)
            {
                if (orderNumber == validValues[i])
                {
                    itemInStock = true;
                    position = i;
                    break;                              // break omdat hij na het vinden van het getal anders zal bijven doorzoeken   
                }
            }
            if (itemInStock)
            {
                Console.WriteLine($"Item found at position {position+1}");            //+1 om te maken dat hij positie 0 niet mee rekend( is logischer voor gebruiker)
            }
            else
            {
                Console.WriteLine("Item not found");
            }
            #endregion

        }
    }
}
