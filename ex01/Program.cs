﻿using System;

class Program
{
  static void Main()
  {

    Console.WriteLine("Transformando em Numeros Romanos!");
    Console.WriteLine("Informe um valor entre 0 e 4000:");

    int number = int.Parse(Console.ReadLine());

    romanNumber(number);

  }

  static void romanNumber(int number)
  {

    int u = number % 10;
    int d = ((number % 100) - u) / 10;
    int c = ((number % 1000) - u - d) / 100;
    int m = number / 1000;

    string result = "";

    switch (m)
    {
      case 1:
        result = "M";
        break;
      case 2:
        result = "MM";
        break;
      case 3:
        result = "MMM";
        break;
      case 4:
        result = "MMMM";
        break;
      default:
        break;
    }

    switch (c)
    {
      case 1:
        result += "C";
        break;
      case 2:
        result += "CC";
        break;
      case 3:
        result += "CCC";
        break;
      case 4:
        result += "CD";
        break;
      case 5:
        result += "D";
        break;
      case 6:
        result += "DC";
        break;
      case 7:
        result += "DCC";
        break;
      case 8:
        result += "DCCC";
        break;
      case 9:
        result += "CM";
        break;

      default:
        break;
    }

    switch (d)
    {
      case 1:
        result += "X";
        break;
      case 2:
        result += "XX";
        break;
      case 3:
        result += "XXX";
        break;
      case 4:
        result += "XL";
        break;
      case 5:
        result += "L";
        break;
      case 6:
        result += "LX";
        break;
      case 7:
        result += "LXX";
        break;
      case 8:
        result += "LXXX";
        break;
      case 9:
        result += "XC";
        break;
      default:
        break;
    }

    switch (u)
    {
      case 1:
        result += "I";
        break;
      case 2:
        result += "II";
        break;
      case 3:
        result += "III";
        break;
      case 4:
        result += "IV";
        break;
      case 5:
        result += "V";
        break;
      case 6:
        result += "VI";
        break;
      case 7:
        result += "VII";
        break;
      case 8:
        result += "VIII";
        break;
      case 9:
        result += "IX";
        break;
      default:
        break;
    }



    Console.WriteLine($"{result}");
  }


}