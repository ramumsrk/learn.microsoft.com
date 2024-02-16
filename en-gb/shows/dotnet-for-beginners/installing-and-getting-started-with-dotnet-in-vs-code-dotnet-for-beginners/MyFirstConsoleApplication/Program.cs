System.Console.Write("What is your name? ");
var myName = System.Console.ReadLine();
var todaysDate = DateTime.Now;
System.Console.WriteLine(
  $"{Environment.NewLine}Hello, {myName}, on {todaysDate}"
);
System.Console.WriteLine(
  $"{Environment.NewLine}Press any key to exit..."
);
System.Console.ReadKey(true);