using System; 

namespace Learning 
{ 
	
  public class Demo
  {
	 public string color = "Red";
	 string car = "BMW"; 
	 
	 public string GetCar()
	 {
		 return car;
	 }
  }
	
  public class ClassExample2
  {
    public static void Main(string[] args)
    { 
	  Demo demoObj = new Demo();
      Console.WriteLine(demoObj.color); 
	  Console.WriteLine(demoObj.GetCar()); // Accessing Private member 	 
    }
  }
}