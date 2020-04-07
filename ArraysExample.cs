using System; 
using System.Linq;

namespace Learning 
{ 
  public class ArraysExample
  {
    public static void Main(string[] args)
    {  	
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
	  int[] myNum = {10, 20, 30, 40};
	  	
	  Console.WriteLine(myNum.Max());	// using System.Linq;
	  Console.WriteLine(myNum.Min());   // using System.Linq; 
	  Console.WriteLine(myNum.Sum());   // using System.Linq;
		
	  Console.WriteLine("\n");	
	  Console.WriteLine(cars[0]);	
	  Console.WriteLine(myNum[3]);	 
		
	  cars[0] = "Maruti";
	  Console.WriteLine(cars[0]); 
		
      Console.WriteLine(cars.Length);	
	   		
	  
		
	 Console.WriteLine("\n");	
		
	 for (int i = 0 ; i < cars.Length; i++)	
	 {
		Console.WriteLine(cars[i]);  
	 }
		
	 Console.WriteLine("\n");
	 Array.Sort(cars);
		
	 foreach (string item in cars)	
	 {
		Console.WriteLine(item);   
	 }
		
		
    }
  }
}