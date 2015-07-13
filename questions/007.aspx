<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/templates/Master.master" CodeFile="007.aspx.cs" Inherits="_007" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <blockquote>
        <p>By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.</p>

        <p>What is the 10001st prime number?</p>
    </blockquote>

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
                      
        int i = 1;
        int prime = 1;
        
        while (true)
        {
            if (prime == 10001 && IsPrime(i))
            break;

            if (IsPrime(i))
                prime++;             

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

