<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="001.aspx.cs" Inherits="_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.</p>

        <p>Find the sum of all the multiples of 3 or 5 below 1000.</p>
    </blockquote>

    <article>
        <pre><code class="language-csharp">
 List<int> list = new List<int>();

        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0)
                list.Add(i);
            if (i % 5 == 0 && i % 3 != 0)
                list.Add(i);
        }

        int answer = list.Sum();
         </code></pre>

    </article>
    <aside>
        <h2>Answer:
            <asp:Literal ID="litAnswer" runat="server"></asp:Literal></h2>
        <h2>Time Taken</h2>
        <asp:Literal ID="litStopWatch" runat="server"></asp:Literal></h2>
    </aside>
</asp:Content>

