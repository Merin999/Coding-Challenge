//// See https://aka.ms/new-console-template for more information


////-------------------------------Question 1-------------------------------------------
//var Passengers = new String[10];
//Console.WriteLine("Enter the names");
//for (var i = 0; i < Passengers.Length; i++) {

//    Passengers[i] = Console.ReadLine();
//}
//Console.WriteLine();

//Console.WriteLine(String.Join(", ", Passengers));
////==================a======================Ascending
//Console.WriteLine();
//string temp = " ";
//for (int i = 0; i < Passengers.Length; i++)
//{
//    for (int j = i + 1; j < Passengers.Length; j++)
//    {
//        if (Passengers[i][0] > Passengers[j][0])
//        {
//            temp = Passengers[j];
//            Passengers[j] = Passengers[i];
//            Passengers[i] = temp;
//        }
//    }
//}
//Console.WriteLine("Ascending order:");
//for (int i = 0; i < Passengers.Length; i++)
//{
//    Console.WriteLine(Passengers[i]);
//}
////===================b==========================Descending
//Console.WriteLine();
//Console.WriteLine();
//string temp1 = " ";
//for (int i = 0; i < Passengers.Length; i++)
//{
//    for (int j = i + 1; j < Passengers.Length; j++)
//    {
//        if (Passengers[i][0] < Passengers[j][0])
//        {
//            temp = Passengers[j];
//            Passengers[j] = Passengers[i];
//            Passengers[i] = temp;
//        }
//    }
//}
//Console.WriteLine("Descending order:");
//for (int i = 0; i < Passengers.Length; i++)
//{
//    Console.WriteLine(Passengers[i]);
//}
////================e=================Split and search

//Console.WriteLine();
////bool flag = false;
//var NewPassengerArray = new String[Passengers.Length];
//Console.Write("Splited Array is  ");
//foreach (var item in Passengers)
//{

//        NewPassengerArray = item.Split(' ');
//        Console.WriteLine(String.Join(", ", NewPassengerArray));
//}

//Console.WriteLine("Enter the name to be searched");
//string SearchName1 = Console.ReadLine();
//int count2 = 0;
//foreach (string item in NewPassengerArray)
//{
//    if (item.ToLower() == SearchName1.ToLower())
//    {
//        //flag = true;
//        Console.WriteLine($"{SearchName1} is in the array ");
//    }
//}
//if (count2 == 0)
//{
//    Console.WriteLine("Item cannot found");
//}

////===================c==========================Search
////Console.WriteLine("Enter the name to be searched");
////string SearchName1 = Console.ReadLine();
////int count2 = 0;
////foreach (var item in Passengers)
////{
////    if (item == SearchName1)
////    {
////        Console.WriteLine($"{SearchName1} is in the array ");
////        break;
////        count2++;
////    }
////}
////if (count2 == 0)
////{
////    Console.WriteLine("Item cannot found");
////}

////==================d================length
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("Length is:");
//for (int i = 0; i < Passengers.Length; i++)
//{
//    int count = 0;
//    foreach (var item in Passengers[i])
//    {

//        if (item == ' ')
//            continue;
//        count++;
//    }
//    Console.WriteLine($"Length of {Passengers[i]} is {count}");
//}





////====================f==================duplicates
//Console.WriteLine();
//var duplicates = new string[Passengers.Length];
//int k = 0;
//foreach (var item in Passengers)
//{
//    int count1 = 0;
//    foreach (var name in Passengers)
//    {
//        if (item == name)
//        {
//            count1++;
//        }
//        if (count1 >= 2)
//        {
//            bool hasFoundMatch = false;
//            foreach (var str in duplicates)
//            {
//                if (str == item)
//                {
//                    hasFoundMatch = true;
//                    break;
//                }
//            }
//            if (!hasFoundMatch)
//                duplicates[k++] = item;
//        }
//    }

//}
//Console.WriteLine(String.Join("  ", duplicates));


////--------------------------------------------Question2----------------------------

//using Coding_Challenge;
//using Tutorials;

//var flightfare = new Flight();

//    Console.WriteLine("Fare: ");
//    string Fare = Console.ReadLine();
//    Console.Write("Time: ");
//    int Time = int.Parse(Console.ReadLine());
//    //Console.WriteLine("AM or PM");
//    //string am_pm = Console.ReadLine();





//using Tutorials;

//var p1 = new Flight();



//Console.WriteLine("Enter Time");
//p1.Time = int.Parse(Console.ReadLine());
//p1.Am_Pm = Console.ReadLine();
//Console.WriteLine("Enter Fare");
//p1.Pfare = int.Parse(Console.ReadLine());

//Console.WriteLine(p1.Pfare);


//----------------------------------Question 3-------------------------------

//var FlightFare = new float[10];
//Console.WriteLine("Enter the flight Fare");
//for (int i = 0; i < FlightFare.Length; i++)
//{
//    FlightFare[i] =float.Parse( Console.ReadLine());
//}
////Console.WriteLine(String.Join(", ", FlightFare));
////ascending order
//float temp = 0;
//for (int i = 0; i < FlightFare.Length; i++)
//{
//    for (int j = i + 1; j < FlightFare.Length; j++)
//    {
//        if (FlightFare[i] > FlightFare[j])
//        {
//            temp = FlightFare[j];
//            FlightFare[j] = FlightFare[i];
//            FlightFare[i] = temp;
//        }
//    }
//}
//Console.WriteLine("Ascending order:");
//for (int i = 0; i < FlightFare.Length; i++)
//{
//    Console.WriteLine(FlightFare[i]);
//}

////descending order
//float temp1 = 0;
//for (int i = 0; i < FlightFare.Length; i++)
//{
//    for (int j = i + 1; j < FlightFare.Length; j++)
//    {
//        if (FlightFare[i] < FlightFare[j])
//        {
//            temp1 = FlightFare[j];
//            FlightFare[j] = FlightFare[i];
//            FlightFare[i] = temp1;
//        }
//    }
//}
//Console.WriteLine("Descending order:");
//for (int i = 0; i < FlightFare.Length; i++)
//{
//    Console.WriteLine(FlightFare[i]);
//}
//Console.WriteLine($"Maximum Fare is {FlightFare[0]}");
//Console.WriteLine($"Minimum Fare is {FlightFare[FlightFare.Length-1]}");
//Console.WriteLine();
//Console.WriteLine("Enter the fare to be searched");
//float SearchItem = float.Parse(Console.ReadLine());
//int f = 0;
//foreach (var item in FlightFare)
//{
//    if( item == SearchItem)
//    {
//        Console.WriteLine($"Fare {item} found");
//        f++;
//    }   
//}
//if (f == 0)
//{
//    Console.WriteLine("Fare not found");
//}


////--------------------------------duplicate
//Console.WriteLine();
//Console.WriteLine();
//var duplicates = new float[FlightFare.Length];
//int k = 0;
//foreach (var item in FlightFare)
//{
//    int count = 0;
//    foreach (var fare in FlightFare)
//    {
//        if (item == fare)
//        {
//            count++;
//        }
//        if (count >= 2)
//        {
//            bool hasFoundMatch = false;
//            foreach (var num in duplicates)
//            {
//                if (num == item)
//                {
//                    hasFoundMatch = true;
//                    break;
//                }
//            }
//            if (!hasFoundMatch)
//                duplicates[k++] = item;
//        }
//    }

//}
//Console.WriteLine(String.Join("  ", duplicates));


//------------------------------Question 5------------------------
//Console.WriteLine("Enter the limit");
//int limit = int.Parse(Console.ReadLine());
//var FlightFare = new float[limit*2];
//Console.WriteLine("Enter the flight Fare");
//for (int i = 0; i < (limit*2); i++)
//{
//    if( i % 2 == 0)
//    {
//        FlightFare[i] = float.Parse(Console.ReadLine());
//        //continue;
//    }
//    //else
//    //{
//    //    FlightFare[i] = float.Parse(Console.ReadLine());
//    //}
//    //Console.WriteLine("-");
//}

//Console.WriteLine(String.Join(", ", FlightFare));

//-------------------------------------question 7--------------------

using Coding_Challenge;

var m = new miles();

Console.WriteLine("Name: ");
string Name = Console.ReadLine();
Console.Write("Miles Travelled: ");
int milestravelled = int.Parse(Console.ReadLine());

m.ShowData();