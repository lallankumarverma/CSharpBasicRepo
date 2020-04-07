using System; 

namespace Learning 
{ 
  public class MethodExample
  {
   	  
	static void MyMethod(string Fname = "Kumar") // Default Argument
	{
	  Console.WriteLine("First Name " + Fname);
	}

	static void FullName(string Fname, string Lname) 
	{
	  Console.WriteLine("Full Name " + Fname + " " + Lname);
	}	
	  
	static int GetAddition(int value1, int value2)
	{
		return value1 + value2;
	}
	
	static double GetArea(double value1, double value2)
	{
		return value1 * value2;
	}
	  
	static double GetArea(double value1, double value2, double value3)
	{
		return value1 * value2 * value3;
	}

	static double GetArea(double value1)
	{
		return 2 * 3.14 * value1;
	}  
	  	  
    public static void Main(string[] args)
    {  	
      int result;
	  double area;
      MyMethod("Carls");  
	  MyMethod("John");
	  MyMethod("Paul"); 
	  MyMethod(); 
	  FullName("James", "Gosling");
	  result = GetAddition(10, 10);	 
	  Console.WriteLine(result);	
	  FullName(Lname: "Kumar", Fname: "Lallan"); // Named argument	 
		
	  area = GetArea(10, 20); // Overloading
	  Console.WriteLine(area);
		
	  area = GetArea(10, 20, 30);
	  Console.WriteLine(area);
		
	  area = GetArea(10);
	  Console.WriteLine(area);		
		
    }
  }
}