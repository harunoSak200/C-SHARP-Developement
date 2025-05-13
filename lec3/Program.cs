int myint = 9 ; 

// implicit typecasting
double mydouble = myint ; 

Console.WriteLine(myint) ; 
Console.WriteLine(mydouble) ; 


// explicit typecasting
mydouble = 9.36562D ; 
int intval = (int)mydouble ; 
Console.WriteLine(mydouble) ; 
Console.WriteLine(intval) ; 


// Type conversion methods in the c# : 
int x_val = 10 ; 
double myd = 5.25 ; 
bool mybool = true ;

Console.WriteLine(Convert.ToString(x_val)+" 8025") ; 
Console.WriteLine(Convert.ToDouble(x_val)+1000); 
Console.WriteLine(Convert.ToInt32(myd)+100) ; 
Console.WriteLine(Convert.ToString(mybool)+" 8525") ; 

// how to take user input in the c# : 
Console.WriteLine("Enter username : ") ; 
string username = Console.ReadLine() ; 
Console.WriteLine("username is : "+username) ;


Console.WriteLine("Enter the age : ");
int age = Convert.ToInt32(Console.ReadLine()) ; 
Console.WriteLine("Your age is : " + age) ; 



