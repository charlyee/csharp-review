﻿using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 35; // Assigning an int!
            Console.WriteLine("Hello Warren!"+x);

            if ( x < 30 ) {
                Console.WriteLine( "X is less than thirty!" );
            } else if ( x == 30 ) {
                Console.WriteLine( "X is thirty!" );
            } else {
                Console.WriteLine( "X is greater than Thirty!" );
            }
        }
    }
}
