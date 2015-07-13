using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _007 : System.Web.UI.Page
{
    MathFunctions MathClass = new MathFunctions();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        int i = 1;
        int prime = 1;
        
        while (true)
        {
            if (prime == 10001 && MathClass.IsPrime(i))
            break;

            if (MathClass.IsPrime(i))
                prime++;             

            i++;
        }

        int answer = i;

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }
}