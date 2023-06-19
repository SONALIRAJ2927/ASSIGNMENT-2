//.1) write a c# sharp program to accept two integers and check whether they are equal or not.
//Using System

//Console.WriteLine(EqualorNot(16, 40));

//bool EqualorNot(int c, int d)
//{
// if (c == d)
// {
//  return true;
//  }
// else
// {
//  return false;
//}
//}

//.............................................................................

//2). write a c# sharp program to check whether a given no. is positive or negative.


//using System

//Console.WriteLine(Positive(40));



//Console.WriteLine(" It is Positve");
//bool Positive(int a)
//{

// if (a >= 0)
// {
// return true;



//  }
// else
//  {
//  return false;
// }
//}

//................................................................................

//3).Write a c#  sharp program to find out whether a given year is leap year or not.


//Console.WriteLine("Enter a year");
//String LeapYear(int a)
//{
//if (a % 4 == 0)
//  {
//  return " This is Leap Year";
// }
//  else
// {
//  return " This is not a leap year";
// }
//}
//............................................................................
//4).Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.

// Console.WriteLine("input age of candidate");
//String int age
// 
// if (age <= 18)
// {
// return "you are not eligible to caste your vote.\n");
//  }
// else
// return "you are eligible casting your vote.\n");

// }
//}
//..............................................................................

//5).Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.

//Console.WriteLine(Display(-1));



//int Display(int m)

//{

//  int n;



// if (m > 0)

//  {

//  return n = 1;

// }

//  else if (m == 0)

//  {

//  return n = 0;

//  }

//  else

//  {

//   return n = -1;

//  }

//}
//..............................................................................

//for Loop:-7.Write a program in C# Sharp to display the first 10 natural numbers

// Console.WriteLine("first 10 natural no".);
//Console.WriteLine("sum ot 10 natural number are");
//Console.WriteLine(SumofNumber(10));

//Int SumofNumber(int a)
//{    int sum = 0;

//  for (int i = 1; i <= a; i++)
// {
//  sum = sum + i;
//  }

//  return sum;
//}
//...........................................................................

//8)Write a C# Sharp program that displays the sum of n natural numbers.

//Console.WriteLine(SumofnNo(Convert.ToInt32(Console.ReadLine())));
//Int SumofnNo(int a)
//{
// int sum = 0;

// for (int j = 0; j <= a; j++)
//  {
// sum = sum + j;
//  }
//  Console.WriteLine("Sum of nos are");

//  return sum;
//............................................................................

//9)Write a C# Sharp program to read 10 numbers and find their average and sum .

//Console.WriteLine(SumAvg(10));

//int SumAvg(int num)
//{

//    int sum = 0;

//    double avg = 0;

//    for (int i = 1; i <= 0; i++)

//    {

//        sum=sum + i;

//        avg = sum/ 10.o;

//        Console.WriteLine(i);

//        sum += i;

//    }

//    Console.WriteLine(" The sum is : {0}" ,sum);


//    Console.WriteLine("The Avg is : {0}",avg);
//    return sum;

//}
//.............................................................................


//10)Write a C# Sharp program to display the cube of an integer up to given number.
//Console.WriteLine(CubeOfNum(2));
//int CubeOfNum(int num)
//{
//    int sum = 0;

//    for (int i = 1; i <= num; i++)
//    {
//        sum = i * i * i;
//        Console.Write(sum + " ");
//        Console.WriteLine();
//    }
//    return sum;
//}

//...................................................................

//11).write a program in c#sharp to display the multiplication table of a given integer.
//Expected output:
//15*1=15
//......
//......
//15*10=150

//MulofNum(15);
//void MulofNum(int num)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine("{0} * {1} = {2}", i, num,i * num);
//    }
//}

//12).Write a program in c# sharp to display the multiplication table vertically from 1 to n.

//13).Multiplication table from 1 to 8
1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
////MulVertically(8);
//void MulVertically(int num)
//{
//    int k,l;

//    for (int k = 1; k <= num; k++)
//    {
//        for (l = 1; l <= k; l++)
//        {

//            Console.Write("{0} * {1} = {2}     ", k, l,( k * l);
//        }
//        Console.WriteLine();
//    }
//}
//........................................................................


//14)Write a program in C# Sharp to display a right angle triangle with an asterisk.
//The pattern like:
//*
//* *
//* * *
//* * * *


//void Asterisk(int rows)

//{
   // int i, j;

   // for (i = 1; i <= rows; i++)


  //  {

     //   for (j = 1; j <= i; j++)

     //   {

          //  Console.Write("*");

      //  }

      //  Console.WriteLine();

//}
//}
//..........................................................................


//15)Write a program in c# sharp to display a pattern like a right angle triangle with a number.
//1
//1 2
//1 2 3 
// 1 2 3 4 

//void RightAngleTriangle(int num)

//{
   // int i, j;
   // for (i = 1; i <= num; i++)

  //  {

       // for (j = 1; j <= i; j++)

       // {

          //  Console.Write(j + " ");

      //  }

      //  Console.WriteLine();

  //  }
    //....................................................................
    //16).Write a c# sharp program to calculate the factorial of a given number.
  
   // void Factorial(int num)
   // {
        //int k, fact = 1;

      // Console.WriteLine("Enter any value");

       // num = Convert.ToInt32(Console.ReadLine());

      //  for (k = 1; k <= num; k++)
      //  {
           // fact = fact * k;
     //   }
        //Console.WriteLine("factorial of above no is " + fact);
  //  }

  //.................................................................................
  //17). Write a program in c#sharp to display the multiplication table vertically from 1 to n.

  //void MulVertically(int num)
  //{
  //    int k,l;

//    for (int k = 1; k <= num; k++)
//    {
//        for ( l= 1; l<= k; L++)
//        {

//            Console.Write("{0} * {1} = {2}" , k,l,k*l);

//        }
//        Console.WriteLine();
//    }
//}





