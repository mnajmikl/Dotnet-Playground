// See https://aka.ms/new-console-template for more information
using System;

int[] myNum1 = new int[4] { 10, 20, 30, 40 };
int[] myNum2 = new int[4] { 50, 60, 70, 80 };
foreach (int i in myNum1)
    Console.Write(i + " ");
foreach (int i in myNum2)
    Console.Write(i + " ");
Console.WriteLine();
(myNum2, myNum1) = (myNum1, myNum2);
foreach (int i in myNum1)
    Console.Write(i + " ");
foreach (int i in myNum2)
    Console.Write(i + " ");
