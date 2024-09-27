using NetFundamentalsStandardLibrary;

Console.WriteLine("Enter your firstname");

var firstname = Console.ReadLine();
var result = StringConcatinator.Concatenate(firstname);

Console.WriteLine(result);