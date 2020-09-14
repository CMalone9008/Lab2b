using System;

class MainClass {
  public static void Main (string[] args) {
  
  Console.WriteLine("Enter Salesperson name:");
  string name = Console.ReadLine();
  Console.WriteLine("Enter sales amount:");
  double sales, comm;
  sales = double.Parse(Console.ReadLine());
  comm = 200 + (0.09 * sales);
  Console.WriteLine("Sales commission for " + name + " is " + "$" + comm);
  
  if (sales<2999) 
  {
    Console.WriteLine("Performance is poor");
  }
  else if ((sales>3000) && (sales<4999))
  {
    Console.WriteLine("Performance is average");
  }
  else if ((sales>5000) && (sales<9999))
  {
    Console.WriteLine("Performance is good");
  }
  else if ((sales>10000) && (sales<14999))
  {
    Console.WriteLine("Performance is excellent");
  }
  else
  {
    Console.WriteLine("Performance is outstanding");
  }

   
  }
}