// Reza naghipoor


using currency1;

using currency4;
using currency5;
using currency6;
using System.Security.Cryptography;

ApiHelper.InitializeClient();
var currencyinfo = await currencyprocess.currencyinformation();

Console.Write($"this is your production:    ");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(currencyinfo.sell);
Console.ResetColor();
Prediction Pred = new Prediction();
Data data = new Data();
do
{
    data.data();
    Pred.prediction();



} while (true);









