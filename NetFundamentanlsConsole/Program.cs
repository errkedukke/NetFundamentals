using NetFundamentalsStandardLibrary;

Console.WriteLine("Enter your firstname");

var firstname = Console.ReadLine();
var result = StringConcatinator.Concatinate(firstname);

Console.WriteLine(result);