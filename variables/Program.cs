

using System;

class Program
{
    static void Main(string[] args)
    {
        // string :  
        string num = "john";
        Console.WriteLine(num);

        //int :
        int myNum = 15;
        Console.WriteLine(myNum);

        //Other Types : 
       
        double myDoubleNum = 5.996551351381351351D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";
        float pi = 3.14f ; 

        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);
        Console.WriteLine(pi);

        string name = "aditya kshatriya" ; 
        Console.WriteLine("hello" + name) ; 

        // constants : 
        const int x = 12 ; 
        // x = 20 ;  this will give an error.
        Console.WriteLine(x) ; 
        

        // declaring multiple variables at same time : 
        int  y = 4 , z = 8 ; 
        y = z  = 80 ; 
        Console.WriteLine(x+y+z) ;
    }
}




