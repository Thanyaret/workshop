using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class CalendarInsert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            setDayDDY();
            setMonthDDY();
            setYearDDY();
        }
    }
    public void setDayDDY()
    {
        for (int i = 1; i <= 31; i++)
        {
            DropDownListDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }
    public void setMonthDDY()
    {
        for (int i = 1; i <= 12; i++)
        {
            DropDownListMonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }
    public void setYearDDY()
    {
        int CY = DateTime.Now.Year;
        for (int i = CY - 5; i <= CY + 1; i++)
        {
            DropDownListYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            
            string Ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            string NewName = Guid.NewGuid().ToString();
            string cNewName = string.Format("{0}{1}", NewName, Ext);
            string Path = "Upload/";
            string cPath = Server.MapPath(string.Format("{0}{1}",Path ,cNewName));
            FileUpload1.SaveAs(cPath);
            Labelupload.Visible = true;
        }
       
    }

}  

   

