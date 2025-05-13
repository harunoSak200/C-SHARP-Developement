using System;

public class Test
{
	public static void Main()
	{
		int t  = Convert.ToInt32(Console.ReadLine()) ; 
		while(t-->0){

		    
		    string str = Console.ReadLine() ; 
		    string[]input = str.Split(" ") ; 
		    
		    int x = Convert.ToInt32(input[0]) , y = Convert.ToInt32(input[1]); 
		    

		    
		    if(x >= y){
		        Console.WriteLine("YES") ; 
		    }
		    else Console.WriteLine("NO") ; 
		}
		
	}
}
