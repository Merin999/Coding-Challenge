//// See https://aka.ms/new-console-template for more information


////-------------------------------Question 1-------------------------------------------
//var Passengers = new String[10];
//Console.WriteLine("Enter the names");
//for (var i = 0; i < Passengers.Length; i++)
//{

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
//class => Flight


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
//class => miles

//using Coding_Challenge;

//var m = new miles();

//Console.WriteLine("Name: ");
//m.Name = Console.ReadLine();
//Console.Write("Miles Travelled: ");
//m.milestravelled = int.Parse(Console.ReadLine());
//m.Flyerpoints = 0;
//Console.WriteLine($"Flyerpoints   :{m.Flyerpoints}");

//-----------------------------------question 4 --------------------------------


//DateTime DOB;
//Console.WriteLine("Enter Name");
//String Name = Console.ReadLine();
//Console.WriteLine("Enter the Date of Birth");
//DOB = DateTime.Parse(Console.ReadLine());

//int Ageyears = (int)((DateTime.Now - DOB).TotalDays / 365);
//Console.WriteLine($"Age of {Name} in years is {Ageyears}");

//double Agedays = (DateTime.Now - DOB).TotalDays;
//Console.WriteLine($"Age of {Name} in days is {Agedays}");

//double Agemonth = Agedays / 30.4;
//Console.WriteLine($"Age of {Name} in month is {Agemonth}");

//double Ageweeks = Agedays / 7;
//Console.WriteLine($"Age of {Name} in weeks is {Ageweeks}");

//double Agehours = Agedays * 24;
//Console.WriteLine($"Age of {Name} in hours is {Agehours}");

//int Year = DOB.Year;
//Console.WriteLine(Year);

//if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
//{
//    Console.WriteLine($"{Year} is Leap Year");
//}
//else
//{
//    Console.WriteLine($"{Year} is not a leap year");
//}

//------------------------------------Question 9--------------------------------------

//using System;

//var dob = new DateTime[10];
//Console.WriteLine("Enter the Date of Birth of 10 passengers ");
//for (int i = 0; i < dob.Length; i++)
//{
//    dob[i] = DateTime.Parse(Console.ReadLine());
//}
////Console.WriteLine(String.Join(", ", dob));
//string Category=" ";
//int Age;
//for (int i = 0; i <= dob.Length; i++)
//{
//    Age = (int)((DateTime.Now - dob[i]).TotalDays / 365);
//    if (Age < 10)
//        Category = "Kid";
//    else if (Age > 10 && Age < 30)
//        Category = "Youth";
//    else if (Age > 30 && Age < 60)
//        Category = "Adult";
//    else 
//        Category = "Older";
//    Console.WriteLine($"{i}  Category: {Category}");
//}

//--------------------------------------------Question 8------------------------------

//var FlightFare = new float[10];
//var Destination = new string[10];
//Console.WriteLine("Enter the Flight Fare");
//for (int i = 0; i < FlightFare.Length; i++)
//{
//    FlightFare[i] = float.Parse(Console.ReadLine());
//}
//Console.WriteLine("Enter the Destination");
//for (var i = 0; i < Destination.Length; i++)
//{
//    Destination[i] = Console.ReadLine();
//}
//Console.Write("Flight Fare : ");
//Console.WriteLine(String.Join(", ", FlightFare));
//Console.Write("Destination : ");
//Console.WriteLine(String.Join(", ", Destination));

//int SearchItem;
//Console.WriteLine("Enter the position to be displayed");
//SearchItem = int.Parse(Console.ReadLine());
//if (SearchItem < FlightFare.Length)
//{
//    Console.WriteLine($"Flight Fare is  {FlightFare[SearchItem]} ");
//    Console.WriteLine($"Destination is  {Destination[SearchItem]}");
//}
//else
//{
//    Console.WriteLine("Invalid Option");
//    Console.WriteLine($"Enter numbers between 0 to {FlightFare.Length-1}");
//}


//----------------------------------------------question 12-----------------------------------

var Name = new string[5];
var Destination = new string[5];

Console.WriteLine("Enter Passenger Names");
for (int i = 0; i < Name.Length; i++)
{
    Name[i] = Console.ReadLine();
}
Console.WriteLine("Enter the Destinations");
for (int i = 0; i < Destination.Length; i++)
{
    Destination[i] = Console.ReadLine();
}

var NewArray = new string[Name.Length + Destination.Length];
int j = 0;
for (int i = 0; i < NewArray.Length; i+=2)
{
    NewArray[i] = Name[j];
    NewArray[i + 1] = Destination[j];
    j++;
}
Console.WriteLine("New Array is ");
Console.WriteLine(String.Join(", ", NewArray));