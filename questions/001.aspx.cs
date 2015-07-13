using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();


        List<int> list = new List<int>();

        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0)
                list.Add(i);
            if (i % 5 == 0 && i % 3 != 0)
                list.Add(i);
        }

        int answer = list.Sum();

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }
}