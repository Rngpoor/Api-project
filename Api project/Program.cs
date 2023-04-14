// Reza naghipoor


using currency1;

using currency4;

ApiHelper.InitializeClient();
var currencyinfo = await currencyprocess.currencyinformation();

Console.Write($"this is your production:    ");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(currencyinfo.sell);
Console.ResetColor();




