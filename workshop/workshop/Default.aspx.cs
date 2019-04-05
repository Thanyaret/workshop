using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        LabelOnclick.Text = Calendar1.SelectedDate.ToString();
    }
}
    
  