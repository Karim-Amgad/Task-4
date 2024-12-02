using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;

namespace Task_4
{
    #region Enum Declaration
    //enum problem in part 2
    enum DayOfWeek 
    { 
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
    }
    #endregion
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem-1

            //int[] numbers = new int[] { 1, 2, 3 };
            //int[] numbers2 = new int[3];
            //int[] numbers3 = { 1, 2,3  };


            //numbers2[0] = 1;
            //numbers2[1] = 2;
            //numbers2[2] = 3;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]); // error : OutOfIndexExceptionn

            #endregion

            #region Question-1

            // The default values assigned in array in C# are

            // int = 0
            // double = 0
            // char = ' ' (space)
            // bool = false
            // String = null

            //int[] test = new int[1];
            //double[] test2 = new double[1];
            //char[] test3 = new char[1];
            //bool[] test4 = new bool[1];
            //String[] test5 = new String[1];

            //Console.WriteLine(test[0]);
            //Console.WriteLine(test2[0]);
            //Console.WriteLine(test3[0]);
            //Console.WriteLine(test4[0]);
            //Console.WriteLine(test5[0]);


            #endregion

            #region Problem-2

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            ////// Shallow Copy

            //arr2 = arr1;
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //arr1[0] = 45354;
            //Console.WriteLine(arr2[0]);

            ////// any change occures in arr1 after the copy process will affect arr2

            //// Deep Copy
            //arr2 = (int[])arr1.Clone();

            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //arr1[0] = 45354;
            //Console.WriteLine(arr2[0]);

            //// any change occures in arr1 afer the copy process will not affect arr2

            #endregion

            #region Question-2

            // Array.Copy makes a shallow copy
            // Array.Clone makes a deep copy

            #endregion

            #region Problem-3

            //int[,] Grades = new int[3, 3];
            //Console.WriteLine("Input the first student's grade for first subject");
            //Grades[0, 0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the first student's grade for second subject");
            //Grades[0, 1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the first student's grade for third subject");
            //Grades[0, 2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the second student's grade for first subject");
            //Grades[1, 0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the second student's grade for second subject");
            //Grades[1, 1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the second student's grade for third subject");
            //Grades[1, 2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the third student's grade for first subject");
            //Grades[2, 0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the third student's grade for second subject");
            //Grades[2, 1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input the third student's grade for third subject");
            //Grades[2, 2] = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= 2; i++)
            //{
            //    String S1 = $"The student {i + 1} has :";
            //    Console.WriteLine(S1);
            //    for (int j = 0; j <= 2; j++)
            //    {
            //        String S2 = $" in class {j + 1} grade equals " + Grades[i, j];
            //        Console.WriteLine(S2);
            //    }
            //}

            #endregion

            #region Question-3

            // Length : it brings the total number of elements in the array [length = no of rows * no of columns]
            //GetLength : it brings the total number of elements in either the column or the row


            //int[,] test = { {1, 2}, {4,8}, {16,32}};
            //Console.WriteLine(test.Length); // 6
            //Console.WriteLine(test.GetLength(0));  // 3
            //Console.WriteLine(test.GetLength(1));  // 2
            #endregion

            #region Problem-4

            //int[] array = { 1, 6, 8, 6, 7, 2, 33, 7821, 5862786 };


            //Array.Sort(array);
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //// it orders the array ascending according to values in it            

            ////----------------------------------------------------------------------------------------------

            //Array.Reverse(array);
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //// it reverses the order of array

            ////------------------------------------------------------------------------------------------------

            //int index = Array.IndexOf(array,33);
            //Console.WriteLine(index);
            //// it prints the first index whuch this element has the same value entered to it

            ////-------------------------------------------------------------------------------------------------

            //int[] array2 = new int[5];
            //Array.Copy(array, array2, 5);
            //Console.WriteLine(array2[0]);
            //Console.WriteLine(array2[1]);
            //Console.WriteLine(array2[2]);
            //Console.WriteLine(array2[3]);
            //Console.WriteLine(array2[4]);
            //// it copies the elements from any array to another according to entered length

            ////-------------------------------------------------------------------------------------------------

            //Array.Clear(array, 3, 4);
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //Console.WriteLine(array[4]);
            //Console.WriteLine(array[5]);
            //Console.WriteLine(array[6]);
            //Console.WriteLine(array[7]);

            //// it clears the elements of array using input start index and the number of indexies to be deleted and replaces them with zero

            #endregion

            #region Question-4

            //Array.Copy : it copies elements from one array to another and throws exception of InvalidCastException in case the size or data type is
            //             not compatiable.
            //Array.ConstrainedCopy : it ensures that the elements of array are copied only if they are compatible with type constrains and if it isn’t
            //                        compatible it will throw an ArrayTypeMismatchException instead of InvalidCastException.

            #endregion

            #region Problem-5

            //int[] a1 = { 11, 22, 33, 44, 55, 66 };

            //for (int i = 0; i < a1.Length; i++)
            //{ 
            //    Console.WriteLine(a1[i]);
            //}

            //----------------------------------------------------------------------------

            //foreach (int i in a1)
            //{
            //    Console.WriteLine(i);

            //}

            //----------------------------------------------------------------------------

            //int i = a1.Length - 1;
            //while (i >= 0)
            //{
            //Console.WriteLine(a1[i]);
            //i--;
            //}


            #endregion

            #region Question-5

            // because it provides a clean code which simplifies the readability
            // because we can't modify the results inside foreach loop


            #endregion

            #region Problem-6

            //int Number;
            //bool z;
            //do
            //{
            //    Console.WriteLine("Enter Positive Odd Number ");
            //    z = int.TryParse(Console.ReadLine(), out Number);
            //}
            //while (Number % 2 != 1 || !z || Number < 0);

            #endregion

            #region Question-6

            // because it ensures that user inputs are correct and in the expected form. It helps to avoid exceptions in the program

            #endregion

            #region Problem-7

            //int[,] array = { {1,2,3},{4,5,6},{7,8,9},{11,22,99} };
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    { 
            //    Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine(' ');    
            //}

            //// first loop determines the row
            //// second loop determines the column then we print the elemwnt with space next to it
            //// after we finish the row we go to a new line and start with the following row

            #endregion

            #region Question-7

            // Like we did in the previous problem by making the output look like a matrix which eases the readability by using Consule.Write
            // instead of Consule.WriteLine

            // also to put the spacing between elements into considerations


            #endregion

            #region Problem-8

            //Console.WriteLine("Enter The Month Number between 1 and 12");
            //String S1= Console.ReadLine();
            //bool m = int.TryParse(S1, out int Number);

            //// Using if statement
            //if (Number == 1)
            //    Console.WriteLine("The month is Jan");
            //else if (Number == 2)
            //    Console.WriteLine("The month is Feb");
            //else if (Number == 3)
            //    Console.WriteLine("The month is Mar");
            //else if (Number == 4)
            //    Console.WriteLine("The month is April");
            //else if (Number == 5)
            //    Console.WriteLine("The month is May");
            //else if (Number == 6)
            //    Console.WriteLine("The month is June");
            //else if (Number == 7)
            //    Console.WriteLine("The month is July");
            //else if (Number == 8)
            //    Console.WriteLine("The month is August");
            //else if (Number == 9)
            //    Console.WriteLine("The month is Sep");
            //else if (Number == 10)
            //    Console.WriteLine("The month is Oct");
            //else if (Number == 11)
            //    Console.WriteLine("The month is Nov");
            //else if (Number == 12)
            //    Console.WriteLine("The month is Dec");
            //else
            //    Console.WriteLine("Please Enter a Valid Number");

            ////Using Switch

            //switch (Number)
            //{
            //    case 1:
            //        Console.WriteLine("The month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("The month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("The month is Mar");
            //        break;
            //    case 4:
            //        Console.WriteLine("The month is Apr");
            //        break;
            //    case 5:
            //        Console.WriteLine("The month is May");
            //        break;
            //    case 6:
            //        Console.WriteLine("The month is June");
            //        break;
            //    case 7:
            //        Console.WriteLine("The month is July");
            //        break;
            //    case 8:
            //        Console.WriteLine("The month is August");
            //        break;
            //    case 9:
            //        Console.WriteLine("The month is Sep");
            //        break;
            //    case 10:
            //        Console.WriteLine("The month is Oct");
            //        break;
            //    case 11:
            //        Console.WriteLine("The month is Nov");
            //        break;
            //    case 12:
            //        Console.WriteLine("The month is Dec");
            //        break;
            //    default:
            //        Console.WriteLine("Please Enter a Valid Number");
            //        break;
            //}

            #endregion

            #region Question-8

            // in case the value we compare is a district value like number or char as it goes directly to the same value without comparing
            // with all previous values 

            #endregion

            #region Problem-9

            int[] array = { 1, 6, 8, 6, 7, 2, 33, 7821, 5862786 };
            //Array.Sort(array);
            //Console.WriteLine(array[0]);
            //Console.WriteLine(array[1]);
            //Console.WriteLine(array[2]);
            //Console.WriteLine(array[3]);
            //Console.WriteLine(array[4]);
            //Console.WriteLine(array[5]);
            //Console.WriteLine(array[6]);

            ////---------------------------------------------------------------

            //int c = Array.IndexOf(array, 33);
            //Console.WriteLine(c);

            #endregion

            #region Question-9

            // It depends on the algorithm used, which is Quicksort (for most cases) or Heapsort or Insertion Sort (for small arrays).
            // for large array:
            // for most cases : Quicksort equals n*log(n) where n is number of elements in array
            // for worst case : Quicksort equals n^2 and the little more better is n*log(n)
            // for best case : Quicksort equals n*log(n) 

            // for small array:
            // it equals (n^2) as it switches to insertion sort 

            // to conclude
            // Best & Average case time complexity: ( n*log(n) )
            // Worst case time complexity: ( n*log(n) ) with Introsort or (n^2) in case of poor pivot selection with Quicksort

            #endregion

            #region Problem-10
             
            int sum = 0;
            int[] mm = { 1, 6, 9, 15, 324, 787, 23, 13 };

            //// for
            //for (int i = 0; i < mm.Length; i++)
            //{
            //    sum += mm[i];
            //}
            //Console.WriteLine("The sum of all numbers is "+sum);

            //// for each
            //foreach (int i in mm)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("The sum of all numbers is "+sum);


            #endregion

            #region Question-10

            // if you want to have a more readiable code and a slightly slower performance, use foreach loop
            // for loop is more efficient for large arrays due to the direct indexing and no extra overhead and if you want a better performance

            #endregion

            //----------------------------------------------------------------------

            // Part 2
            #region Enum

            //Console.WriteLine("Please input the number of day of week");
            //String S2 = Console.ReadLine();
            //int day = int.Parse(S2);
            //{
            //    DayOfWeek daynumber = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day.ToString());
            //    Console.WriteLine($"The corresponding day is: {daynumber}");
            //}

            //// in case of invalid value it will return the input number as it is

            //// so if we want to do a protective code it will be
            //Console.WriteLine("Please input the number of day of week");
            //String S2 = Console.ReadLine();
            //bool h = int.TryParse(S2, out int day);
            //if (day <= 0 || day > 7 || h)
            //    Console.WriteLine("Please input a valid number");
            //else
            //{
            //    DayOfWeek daynumber = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day.ToString());
            //    Console.WriteLine($"The corresponding day is: {daynumber}");
            //}


            #endregion
        }
    }
}
