using System;
using lib.app; //lib.app namespace using as a library.

//Main. Program used as a Main file executable.
public class Program{
  // static void Main is the executable default program in a csharp program.
  public static void Main(string[] args){
    // args: the argument given through command line.
    TestApp application = new TestApp(); // TestApp instantiation.
    // Checking if an argument has been given.
    if(args.Length != 0){
      System.Console.WriteLine("Getting value through command line... ");
      var input = 0;
      string theString = string.Join(" ",args);
      // managing the data type given.
      try
      {
        input = Int32.Parse(theString);
      }
      catch (System.Exception)
      {
        System.Console.WriteLine("[!] >> Wrong type as argument");
      }
      application.SetValue(input); // using SetValue mehtod.
    }
    else{ // default value.
      application.SetValue(717); // using SetValue mehtod.
    }
    var myValue = application.GetValue(); // using GetValue method.
    System.Console.WriteLine("The value set: {0}",myValue);
    System.Console.WriteLine($"The property: {application.TheValue}");
  }
}
