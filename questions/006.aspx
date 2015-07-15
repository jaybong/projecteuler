<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="006.aspx.cs" Inherits="_006" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>The sum of the squares of the first ten natural numbers is: 12 + 22 + ... + 102 = 385</p>

        <p>The square of the sum of the first ten natural numbers is: (1 + 2 + ... + 10)2 = 552 = 3025</p>

        <p>Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.</p>

        <p>Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.</p>
    </blockquote>

    <article>
        <pre><code class="language-csharp">
        int sumsquare = 0;
        int squaresum = 0;

        for (int i = 0; i <= 100; i++)
        {
            sumsquare += i * i;
            squaresum += i;
        }

        squaresum = squaresum * squaresum;

        int answer = squaresum - sumsquare;
         </code></pre>

    </article>
    <aside>
        <h2>Answer:
            <asp:Literal ID="litAnswer" runat="server"></asp:Literal></h2>
        <h2>Time Taken</h2>
        <asp:Literal ID="litStopWatch" runat="server"></asp:Literal></h2>
    </aside>
</asp:Content>

