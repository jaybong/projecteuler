using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _004 : System.Web.UI.Page
{

    static bool CheckMultiples(int increment, int val )
    {
        for (int i = 1; i <= val; i++)
        {
            if (increment % i != 0)
                return false;
        }
        return true;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        List<int> list = new List<int>();
        int i = 1;

        while (true)
        {
            if (CheckMultiples(i,20) == true)
                break;
            else
                i++;
        }

        int answer = i;

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = (stopwatch.ElapsedMilliseconds / 1000).ToString() + " seconds";
    }
}