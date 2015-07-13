using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _002 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        // Begin timing
        stopwatch.Start();


        int i = 1;
        int x = 0;
        int y = 1;
        int total = 0;
        int newtotal = 0;

        while (total < 4000000)
        {
            total = x + y;

            if (i % 2 == 0)
                y = total;
            else
                x = total;

            i++;

            if (total % 2 == 0)
                newtotal += total;
        }

        int answer = newtotal;

        stopwatch.Stop();


        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }
}