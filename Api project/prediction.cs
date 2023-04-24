using currency3;
using currency4;
using currency5;
using System.Diagnostics;

namespace currency6
{
    public class Prediction
    {

        

        public void prediction()

        {
            string address = @"C:\Users\IT CITY\source\repos\Api project\Api project\bin\Debug\net7.0\dsd.txt";
            using (StreamReader streader = new StreamReader(address))
            {
                var line1 = Convert.ToDouble(streader.ReadLine());
                var line2 = Convert.ToDouble(streader.ReadLine());
                var line3 = Convert.ToDouble(streader.ReadLine());

                var plus = line1 + line2 + line3;



                var average1 = plus / 3;

                var currencyinfo = currencyprocess.currencyinformation();

                var x = currencyinfo.Result.high;
                var y = currencyinfo.Result.low;
                var z = Convert.ToDouble( x + y);
                var k = Convert.ToDouble(z) / 2;

                var m = k - average1;
                var predictonbuy = Convert.ToDouble(m + currencyinfo.Result.buy);

                var pred =Convert.ToDouble(currencyinfo.Result.buy) -Convert.ToDouble( predictonbuy);

                var Per = Convert.ToDouble(pred) / Convert.ToDouble( currencyinfo.Result.buy);
                var percent =Per * 100;
                
                Console.Write("This is your possible percent of fault:   %");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(percent);
                Console.ResetColor();







            }
            



        }





    }
}




        }





    }
}


