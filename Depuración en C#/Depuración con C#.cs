﻿using System;
internal class Program
{
    private static void Main(string[] args)
    {

        int num1;

        string num2;
        Console.WriteLine("Introduzca número para ver si es par o impar"); 
        num2 = Console.ReadLine();

        num1 = int.Parse(num2);

        if (num1 % 2 == 0)
        {
            Console.WriteLine("Es par");



        }
        else
        {
            Console.WriteLine("Es impar");


        }


    }
}
