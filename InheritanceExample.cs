using System; 

namespace Learning 
{ 
  class Vehicle
  {
	  public string brand;
	  
	  public void getBrand()
	  {
	     Console.WriteLine("Brand Name is " + brand);
	  }
  }
	
  class Bus : Vehicle
  {
    public string modelName;
  }
  	
  public class InheritanceExample
  {
    public static void Main(string[] args)
    {  	
      Bus busObj = new Bus();
	  busObj.brand = "Ford";
	  busObj.modelName = "VFX100";
	  busObj.getBrand();	 
      Console.WriteLine(busObj.modelName);		
    }
  }
}