using PasswordGenerator;

var password = new PasswordGenerator.Password();
var anotherPassword = password.Next();
System.Console.WriteLine(
  $"Generated password is '{anotherPassword}'"
);