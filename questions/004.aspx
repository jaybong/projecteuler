<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="004.aspx.cs" Inherits="_004" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.</p>

        <p>What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?</p>
    </blockquote>

    <article>
        <pre><code class="language-csharp">
    static bool CheckMultiples(int increment, int val )
    {
        for (int i = 1; i <= val; i++)
        {
            if (increment % i != 0)
                return false;
        }
        return true;
    }

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
         </code></pre>

    </article>
    <aside>
        <h2>Answer:
            <asp:Literal ID="litAnswer" runat="server"></asp:Literal></h2>
        <h2>Time Taken</h2>
        <asp:Literal ID="litStopWatch" runat="server"></asp:Literal></h2>
    </aside>
</asp:Content>

