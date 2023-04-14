using currency4;
using System.Diagnostics;

namespace currency5
{
    public class Data
    {


        public void data()
        {
            string address = @"F:\currency data\time.text";
            StreamWriter stwriter = new StreamWriter(address);

            TimeSpan tens = new TimeSpan(0, 0, 10);

            for (int i = 0; i < 6; i++)
            {

                var currencyinfo = currencyprocess.currencyinformation();

                stwriter.WriteLine(currencyinfo.Result.buy);


                Thread.Sleep(tens);

            }
            stwriter.Close();
        }
    }
}