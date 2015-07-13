using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Humanizer;



public partial class Templates_Master : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~");
        string[] questions = Directory.GetFiles(folderPath + "/Questions", "*.aspx");

        List<object> questionlist = new List<object>();

        string currenturl = Request.CurrentExecutionFilePath;

        foreach (var q in questions)
        {
            int index = q.IndexOf(q);
            Question question = new Question();
            question.QuestionName = Path.GetFileNameWithoutExtension(q).TrimStart(new Char[] { '0' });
            question.QuestionUrl = Path.GetFileName(q);
            questionlist.Add(question);
        }


        rptQuestions.DataSource = questionlist;
        rptQuestions.DataBind();
    }



}

public class Question
{
    public string QuestionName { get; set; }
    public string QuestionUrl { get; set; }
    public string CurrentQuestion { get; set; }

    public string NextQuestionName { get; set; }
    public string NextQuestionUrl { get; set; }
}


