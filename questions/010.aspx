<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="010.aspx.cs" Inherits="_010" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.</p>

        <p>Find the sum of all the primes below two million.</p>
    </blockquote>

    <p style="background: tomato">Note: This answer is currently incorrect.</p>

    <article>
        <pre><code class="language-csharp">
        public bool IsPrime(int val)
         {
            if (val == 1) return false;
            if (val == 2) return true;

            if (val % 2 == 0) return false;

            for (int i = 3; i < val; i += 2)
            {
                if (val % i == 0) return false;
            }

            return true;
        }
            
        List<int> list = new List<int>();
        int j = 0;

        for (int i = 0; i <= 2000000; i++)
        {
            if (MathClass.IsPrime(i))
            {
                j = j += i;
            }
        }

        int answer = j;
         </code></pre>

    </article>
    <aside>
        <h2>Answer:
            <asp:Literal ID="litAnswer" runat="server"></asp:Literal></h2>
        <h2>Time Taken</h2>
        <asp:Literal ID="litStopWatch" runat="server"></asp:Literal></h2>
    </aside>
</asp:Content>

