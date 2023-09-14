using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace _30_LINQ_exersices
{
    internal class Program
    {
        static void Main()
        {
            //exercise 1
            //int[] numbers = new int[10] {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var numQuery = from num in numbers
            //               where num % 2 == 0
            //               select num;
            //foreach (var number in numQuery)
            //{
            //    Console.WriteLine(number);
            //}

            //exercise 2
            //int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};
            //var numQuery = from num in numbers
            //               where num > 0 && num < 11
            //               select num;

            //exercise 3
            //console.write("\nlinq : find the number and its square of an array which is more than 20 : ");
            //int[]  numbers= new[] { 3, 9, 2, 8, 6, 5 };
            //var numQuery = from num in numbers
            //               let sqrnum = num * num
            //               where sqrnum > 20
            //               select new { num, sqrnum };

            // exercise 4
            //int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
            //var numQuery = from num in numbers
            //               group num by num
            //               into y
            //               select y;
            //foreach (var num in numQuery)
            //{
            //    Console.WriteLine("Number " + num.Key + " appearce " + num.Count() + " times");
            //}

            // exercise 5
            //Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            //string str = Console.ReadLine();
            //var numQuery = from num in str
            //               group num by num
            //               into y
            //               select y;
            //foreach (var num in numQuery)
            //{
            //    Console.WriteLine("Character " + num.Key + " : " + num.Count() + " times");
            //}

            //exercise 6
            //string[] Week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //Console.Write("\nLINQ : Display the name of the days of a week : ");
            //var days = from WeekDays in Week
            //           select WeekDays;

            // exercise 7
            //int[] numbers = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            //Console.Write("\nLINQ : Display numbers, number*frequency and frequency : \n");
            //var numQuery = from num in numbers
            //               group num by num into result
            //               select result;
            //Console.Write("Number" + "\t\t" + "Number*Frequency" + "    \t" + "Frequency" + "\n");
            //Console.Write("------------------------------------------------\n");
            //foreach (var num in numQuery)
            //{
            //    Console.WriteLine(num.Key + "\t\t\t" + num.Key * num.Count() + "\t\t    " + num.Count() );
            //}

            //exercise 8
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            //Console.Write("\nInput starting character for the string : ");
            //char start = char.Parse(Console.ReadLine());
            //string startwith = start.ToString().ToUpper();
            //Console.Write("\nInput starting character for the string : ");
            //char end = char.Parse(Console.ReadLine());
            //string endwith = end.ToString().ToUpper();
            //var citiesQuery = from ch in cities
            //                  where ch.StartsWith(startwith)
            //                  where ch.EndsWith(endwith)
            //                  select ch;
            //foreach (var citie in citiesQuery)
            //{
            //    Console.WriteLine($"The city that start with {startwith} and end with {endwith} is {citie}");
            //}

            //exercise 9
            //List<int> list = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            //Console.Write("\nLINQ : Create a list of numbers and display the numbers greater than 80 : \n");
            //var newList = list.FindAll(x => x > 80);
            //foreach (var num in newList)
            //{
            //    Console.WriteLine(num);
            //}

            //exercise 10
            //List<int> list = new List<int>();
            //Console.Write("Input the number of members on the List: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write($"Member {i}: ");
            //    int number = int.Parse(Console.ReadLine());
            //    list.Add(number);
            //}
            //Console.Write("Input the value above you want to display the members of the List: ");
            //int value = int.Parse(Console.ReadLine());
            //List<int> newList = list.FindAll(x => x > value);
            //foreach (int i in newList)
            //{
            //    Console.WriteLine(i);
            //} 

            //exercise 11
            //Console.WriteLine("Input the member count: ");
            //int count = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //Console.WriteLine("The members of the list are: ");
            //for (int i = 0; i < count; i++)
            //{
            //    int member = int.Parse(Console.ReadLine());
            //    list.Add(member);
            //}
            //Console.Write("How many records you want to display? : ");
            //int displayCount = int.Parse(Console.ReadLine());
            //List<int> newList = list.OrderByDescending(x => x).ToList();
            //Console.WriteLine($"The top {displayCount} records from the list are: ");
            //foreach (int item in newList.Take(displayCount))
            //{
            //    Console.WriteLine(item);
            //}

            //exercise 12
            //Console.Write("Input the string: ");
            //string str = Console.ReadLine();
            //string[] splitArray = str.Split(' ');
            //var upperCase = splitArray.Where(x => String.Equals(x, x.ToUpper()));
            //foreach ( var x in upperCase )
            //{
            //    Console.WriteLine(x);
            //}

            //exercise 13
            //Console.Write("Input number of strings to  store in the array : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input {0} strings for the array  :",num);
            //string[] myArray = new string[num];
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("Element [{0}] : ",i);
            //    myArray[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Here is the string below created with elements of the above array: ");
            //string newString = string.Join(", ", myArray);
            //Console.WriteLine(newString);

            //exercise 14
            //Students list = new Students();
            //Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
            //int rank = Convert.ToInt32(Console.ReadLine());
            //var students = (from item in list.GtStuRec()
            //                group item by item.Grade into y
            //                orderby y.Key descending
            //                select new
            //                {
            //                    rec = y.ToList()
            //                }).ToList();
            //students[rank - 1].rec.ForEach(i => Console.WriteLine($" Id : {i.ItemId},  " +
            //    $"Name : {i.Name}," + $"  achieved Grade Point : {i.Grade}"));

            //exercise 15
            //Console.WriteLine("The files are: ");
            //string[] strings = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            //Console.WriteLine("Here is the group of extension of the files: ");
            //var group = strings.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
            //    .GroupBy(z => z, (ext, count) => new
            //    {
            //        Extension = ext,
            //        Count = count.Count()
            //    });
            //foreach (var st in group)
            //{
            //    Console.WriteLine($"{st.Count} File(s) with '{st.Extension}' Extension");
            //}

            //exercise 16
            //string[] files = Directory.GetFiles("C:\\Program Files\\Git\\cmd");
            //var fileSize = files.Select(file => new FileInfo(file).Length).Average();

            //fileSize = Math.Round(fileSize / 10, 1);
            //Console.WriteLine($"The Average file size is {fileSize} MB");

            //exercise 17
            //List<string> listOfString = new List<string> { "m" , "n" , "o" , "p" , "q", "m"};
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var item in listOfString) Console.Write(item + " ");
            //string value = listOfString.FirstOrDefault(x => x == "o");
            //listOfString.Remove(value);
            //Console.WriteLine("\nHere is the list after removing the item 'o' from the list: ");
            //foreach (var c in listOfString) Console.WriteLine("Char: " + c);

            //exercise 18
            //List<string> listOfString = new List<string> { "m", "n", "o", "p", "q", "m" };
            //Console.WriteLine("Here is the list of items: ");
            //foreach (var item in listOfString) Console.Write(item + " ");
            //Console.WriteLine("\nAdd char to remove : ");
            //string ch = Console.ReadLine();
            //listOfString.Remove(listOfString.FirstOrDefault(x => x == ch));
            //Console.WriteLine($"Here is the list after removing the item '{ch}' from the list: ");
            //foreach (var c in listOfString) Console.WriteLine("Char: " + c);

            // exercise 19
            //List<string> listOfString = new List<string> { "m", "n", "o", "p", "q", "m" };
            //Console.Write("Here is the list of items: ");
            //foreach (var item in listOfString) Console.Write(item + " ");
            //Console.Write("\nEnter char: ");
            //string ch = Console.ReadLine();
            //listOfString.RemoveAll(c => c == ch);
            //Console.WriteLine($"\nHere is the list after removing all '{ch}' items from the list: ");
            //foreach (var c in listOfString) Console.WriteLine("Char: " + c);

            // exercise 20,21
            //List<string> listOfString = new List<string> { "m", "n", "o", "p", "q", "m" };
            //Console.Write("Here is the list of items: ");
            //foreach (var item in listOfString) Console.Write(item + " ");
            //Console.Write("\nEnter item index to start with: ");
            //int startIndex = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter count of items you want to remove: ");
            //int count = Convert.ToInt32(Console.ReadLine());    
            //listOfString.RemoveRange(startIndex, count);
            //Console.WriteLine("String after removing: ");
            //foreach (var item in listOfString) Console.Write(item + " ");
            //Console.WriteLine();

            //exercise 22
            //Console.Write("Add length of array :");
            //int length = Convert.ToInt32(Console.ReadLine());
            //string[] myaArray = new string[length];
            //Console.WriteLine($"\nInput {length} strings for the array:");
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write("Element [{0}] : ",i);
            //    string elemet = Console.ReadLine();
            //    myaArray[i] = elemet;
            //}
            //Console.Write("Input the minimum length of the item you want to find :");
            //int minLenght = Convert.ToInt32(Console.ReadLine());
            //var newArray = myaArray.Where(n => n.Length > minLenght);
            //Console.WriteLine("Output : ");
            //foreach (var item in newArray)
            //{
            //    Console.WriteLine(item);
            //}

            //exercise 23
            //char[] charSet = { 'X', 'Y', 'Z' };
            //int[] intSet = { 1, 2, 3, 4, };
            //var cartesianProduct = from ch in charSet
            //                       from num in intSet
            //                       select new { ch , num };
            //foreach (var item in cartesianProduct) Console.WriteLine(item);

            //exercise 24
            //char[] charset = { 'X', 'Y', 'Z' };
            //int[] numset = { 1, 2, 3 };
            //string[] colorset = { "Green", "Orange" };
            //var trioSet = from ch in charset
            //              from num in numset
            //              from color in colorset
            //              select  new {ch, num , color };
            //foreach ( var item in trioSet ) { Console.WriteLine(item); }

            //25,26,27,30
            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemName = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemName = "Chocolate" },
           new Item_mast { ItemId = 3, ItemName = "Butter   " },
           new Item_mast { ItemId = 4, ItemName = "Brade    " },
           new Item_mast { ItemId = 5, ItemName = "Honey    " },
           new Item_mast { ItemId = 6, ItemName = "Honey    " }
            };

            // List<Purchase> purchlist = new List<Purchase>
            // {
            //new Purchase { InvoiceNo=100, ItemId = 3,  PurchaseQuantity = 800 },
            //new Purchase { InvoiceNo=101, ItemId = 2,  PurchaseQuantity = 650 },
            //new Purchase { InvoiceNo=102, ItemId = 3,  PurchaseQuantity = 900 },
            //new Purchase { InvoiceNo=103, ItemId = 4,  PurchaseQuantity = 700 },
            //new Purchase { InvoiceNo=104, ItemId = 3,  PurchaseQuantity = 900 },
            //new Purchase { InvoiceNo=105, ItemId = 4,  PurchaseQuantity = 650 },
            //new Purchase { InvoiceNo=106, ItemId = 1,  PurchaseQuantity = 458 }
            // };
            //exercise 25
            //Console.WriteLine("LINQ : Generate an Inner Join between two data sets : ");
            //var innerJoin = from i in itemlist
            //                join p in purchlist on i.ItemId equals p.ItemId
            //                select new
            //                {
            //                    ItemName = i.ItemName,
            //                    ItemID = i.ItemId,
            //                    PurchaseQuant = p.PurchaseQuantity
            //                };
            //Console.WriteLine("Item ID \tItem Name\t\tQuantity");
            //Console.WriteLine("-----------------------------------------------------");
            //foreach (var data in innerJoin)
            //{
            //    Console.WriteLine($"{data.ItemID}\t\t{data.ItemName}\t\t{data.PurchaseQuant} ");
            //}

            //exercise 26
            //Console.WriteLine("LINQ : Generate an Left Join between two data sets : ");
            //var LeftJoin = from i in itemlist
            //                join p in purchlist on i.ItemId equals p.ItemId
            //                into a
            //                from b in a.DefaultIfEmpty(new Purchase())
            //                select new
            //                {
            //                    ItemName = i.ItemName,
            //                    ItemID = i.ItemId,
            //                    PurchaseQuant = b.PurchaseQuantity
            //                };
            //Console.WriteLine("Item ID \tItem Name\t\tQuantity");
            //Console.WriteLine("-----------------------------------------------------");
            //foreach (var data in LeftJoin)
            //{
            //    Console.WriteLine($"{data.ItemID}\t\t{data.ItemName}\t\t{data.PurchaseQuant} ");
            //}

            //exercise 27
            //Console.WriteLine("LINQ : Generate an Right Join between two data sets : ");
            //var rightJoin = from p in purchlist
            //                join i in itemlist on p.ItemId equals i.ItemId
            //                into a
            //                from b in a.DefaultIfEmpty()
            //                select new
            //                {
            //                    ItemName = b.ItemName,
            //                    ItemID = b.ItemId,
            //                    PurchaseQuant = p.PurchaseQuantity
            //                };
            //Console.WriteLine("Item ID \tItem Name\t\tQuantity");
            //Console.WriteLine("-----------------------------------------------------");
            //foreach (var data in rightJoin)
            //{
            //    Console.WriteLine($"{data.ItemID}\t\t{data.ItemName}\t\t{data.PurchaseQuant} ");
            //}

            //exercise 28
            //string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
            //                                 "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //var newArray = from city in cities
            //               orderby city.Length
            //               select city;
            ////var newArray2 = cities.OrderBy(city => city.Length).ThenBy(city => city);
            //foreach (var item in newArray) Console.WriteLine(item);

            //exercise 29
            //string[] cities =
            //{
            //    "ROME","LONDON","NAIROBI","CALIFORNIA",
            //    "ZURICH","NEW DELHI","AMSTERDAM",
            //    "ABU DHABI", "PARIS","NEW YORK"
            //};
            //var citySplit = from i in Enumerable.Range(0, cities.Length)
            //                group cities[i] by i / 3;

            //foreach (var city in citySplit)
            //    cityView(string.Join(";  ", city.ToArray()));

            //exercise 30
            //var listOfName = from item in itemlist
            //                 select item.ItemName;
            //listOfName = listOfName.Distinct().OrderBy(x => x);
            //foreach ( var item in listOfName ) { Console.WriteLine(item); }
                           



        }
        static void cityView(string cityMetro)
        {
            Console.WriteLine(cityMetro);
            Console.WriteLine("-- here is a group of cities --\n");
        }
    }
}
