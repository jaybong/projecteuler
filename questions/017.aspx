<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="017.aspx.cs" Inherits="_017" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.</p>

        <p>If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?</p>
    </blockquote>

    <article>
        <pre><code class="language-csharp">
    string allwords = "";

    for (int i = 1; i <= 1000; i++)
    {
        string wordnumber = NumberToWords(i);
        allwords = string.Join("", allwords, wordnumber);
    }

    int answer = allwords.Length;


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
         </code></pre>

    </article>
    <aside>
        <h2>Answer:
            <asp:Literal ID="litAnswer" runat="server"></asp:Literal></h2>
        <h2>Time Taken</h2>
        <asp:Literal ID="litStopWatch" runat="server"></asp:Literal></h2>
    </aside>
</asp:Content>

