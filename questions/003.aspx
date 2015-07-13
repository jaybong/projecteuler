<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="003.aspx.cs" Inherits="_003" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>The prime factors of 13195 are 5, 7, 13 and 29.</p>

        <p>What is the largest prime factor of the number 600851475143 ?</p>
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

