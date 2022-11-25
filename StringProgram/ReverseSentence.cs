using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class ReverseSentence
    {
        static void Mainm()
        {
            string str = "i am test engineer";
            string[] arr = str.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }


           
        }
        }
    }
