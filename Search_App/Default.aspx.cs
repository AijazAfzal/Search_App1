using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using BLL; 

namespace Search_App
{
    public partial class _Default : Page
    {
        person_BLL objbll = new person_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void BindGrid()
        {
            var li=objbll.getperson_list();
            grd_tbl.DataSource = li;
            grd_tbl.DataBind(); 
        }

        protected void btn_srfn_Click(object sender, EventArgs e)
        {
            string first_name=txt_fn.Text;
            var obj = objbll.get_firstname(objprop);
            grd_tbl.DataSource = obj;
            grd_tbl.DataBind();
        }

        protected void search_mn_Click(object sender, EventArgs e)
        {
            string middle_name = txt_mn.Text;
            var obj = objbll.get_middlename(objprop); 
            grd_tbl.DataSource = obj;
            grd_tbl.DataBind();

        }

        protected void search_ln_Click(object sender, EventArgs e)
        {
            string last_name=txt_ln.Text;
            var obj = objbll.get_lastname(objprop);
            grd_tbl.DataSource = obj;
            grd_tbl.DataBind();

        }

        protected void seacrh_eml_Click(object sender, EventArgs e)
        {
            string email = txt_empro.Text; 
            var obj = objbll.get_email(objprop);
            grd_tbl.DataSource = obj;
            grd_tbl.DataBind();
        }

        protected void search_date_Click(object sender, EventArgs e)
        {

        }
    }
}