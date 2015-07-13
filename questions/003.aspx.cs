using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _003 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        List<int> list = new List<int>();
        int i = 1;
        while (i < 40000000)
        {

            if (600851475143 % i == 0)
                list.Add(i);



            i++;
        } // loop


        List<int> primelist = new List<int>();
        int z = 2;
        foreach (int x in list)
        {
            while (z < 500000000)
            {
                if (x % z == 0)
                {
                    primelist.Add(x);
                }
                z++;
            }
        }

        primelist.Sort();
        primelist.Reverse();
       // primelist.FirstOrDefault();

        int answer = primelist.FirstOrDefault();

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }
}