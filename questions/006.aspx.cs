using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _006 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        int sumsquare = 0;
        for (int i = 0; i <= 100; i++)
        {
            sumsquare += i * i;
        }

        int squaresum = 0;
        for (int i = 0; i <= 100; i++)
        {
            squaresum += i;
        }
        squaresum = squaresum * squaresum;

        int answer = squaresum - sumsquare;

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }
}