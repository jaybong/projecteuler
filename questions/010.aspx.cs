using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _010 : System.Web.UI.Page
{
    MathFunctions MathClass = new MathFunctions();

    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        List<int> list = new List<int>();
    //    int j = 0;
        for (int i = 0; i < 2000000; i++)
        {
            if (MathClass.IsPrime(i))
            {
               // j = j += i;
                list.Add(i);
            }
        }
        int answer = list.Aggregate(0, (a, b) => a + b); 
       // int answer = j;

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }
}