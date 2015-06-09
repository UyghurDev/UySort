using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UySort_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSort_Click(object sender, EventArgs e)
    {

        string[] straWords=txtWords.Text.Split(Environment.NewLine.ToCharArray());
        Array.Sort(straWords, new net.UyghurDev.Text.Sort());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        foreach (string str in straWords)
        {
            if (!string.IsNullOrEmpty(str))
            {
               sb.AppendLine(str);
            }
        }
        txtWords.Text=sb.ToString();
    }
}
