using System; 

namespace Learning 
{ 
	
  public class Animal
  {
	  public virtual void getAnimalSound()
	  {
		 Console.WriteLine("Animal Sound");
	  }
  }
  
  public class Dog : Animal
  {
	  public override void getAnimalSound() // Override super class method
	  {
		 Console.WriteLine("Dog Sound");
	  }  
    
  }
 
  public class Cat : Animal
  {
	  public override void getAnimalSound() // Override super class method 
	  {
		 Console.WriteLine("Cat Sound");
	  }  	  
	  
  }	
	
  public class PolymorphismExample
  {
    public static void Main(string[] args)
    {  	
      Animal animalObj = new Animal();
	  Dog dogObj = new Dog() ;
	  Cat catObj = new Cat();
		
	  animalObj.getAnimalSound();
	  dogObj.getAnimalSound();
	  catObj.getAnimalSound();	  
	}
  }
}