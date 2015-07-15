using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading;
using Humanizer;

public partial class _017 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        string allwords = "";

        for (int i = 1; i <= 1000; i++)
        {
            string wordnumber = NumberToWords(i);
            allwords = string.Join("", allwords, wordnumber);
        }

        int answer = allwords.Length;

        stopwatch.Stop();

        litAnswer.Text = answer.ToString();
        litStopWatch.Text = TimeSpan.FromSeconds(stopwatch.Elapsed.Seconds).Humanize();
    }

    public static string NumberToWords(int number)
    {
        string words = "";

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + "thousand";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + "hundred";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "" + unitsMap[number % 10];
            }
        }

        return words;
    }

}