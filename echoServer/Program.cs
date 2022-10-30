using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace echoServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // String
            string echoString = "Echo Server!";

            // Revese String
            char[] charArray = echoString.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);

            // Print to Terminal
            Console.WriteLine(echoString);
            Console.WriteLine(reverseString);
        }



    }
}


