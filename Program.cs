using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // For a method to execute we must call it by name.
            // MyMethod();

            // Let's try an array!
            int[] myarray = new int[5] { 3, 4, 5, 6, 7 };
            myarray[0] = 2; // Update value by index. // ARRAYS START AT ZERO!
            Console.WriteLine( myarray[0] ); // Output a value by index.
        }

        // Let's try making a method.
        static void MyMethod()
        {
            int x = 35; // Assigning an int!
            Console.WriteLine("Hello Warren!"+x); // Print something to the commandline.

            // Let's try an if statement!
            if ( x < 30 ) {
                Console.WriteLine( "X is less than thirty!" );
            // We can have many else ifs.
            } else if ( x == 30 ) {
                Console.WriteLine( "X is thirty!" );
            // We can only have 1 "if" and 1 "else" per chain.
            } else {
                Console.WriteLine( "X is greater than Thirty!" );
            }

            // Let's try a switch statement!
            int a = 2;
            switch ( a ) {
                case 1 :
                    Console.WriteLine( "Value is 1!" );
                    break;
                case 2 :
                    Console.WriteLine( "Value is 2!" );
                    break;
                case 3 :
                    Console.WriteLine( "Value is 3!" );
                    break;
                default :
                    Console.WriteLine( "Uh oh, it is another value!" );
                    break;
            }
        }
    }
}
