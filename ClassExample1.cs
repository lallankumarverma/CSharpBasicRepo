using System; 

namespace Learning 
{ 
  public class ClassExample1
  {
	static string color = "Red";
	string car = "BMW";  
	  
    public static void Main(string[] args)
    {  	
      Console.WriteLine(ClassExample1.color); 
	  
      ClassExample1 carObj1 = new ClassExample1();		 
      Console.WriteLine(carObj1.car);

      ClassExample1 carObj2 = new ClassExample1();		 
      Console.WriteLine(carObj2.car);
		
		
    }
  }
}