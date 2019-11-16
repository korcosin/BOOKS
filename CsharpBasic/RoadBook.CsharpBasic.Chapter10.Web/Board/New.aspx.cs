using System;
using System.Text;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;
using RoadBook.CsharpBasic.Chapter10.Examples.Manager;

namespace RoadBook.CsharpBasic.Chapter10.Web.Board
{
    public partial class New : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadbookDB";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "test123!@#";

            MsSqlManager ms = new MsSqlManager();
            ms.Open(dbInfo);

            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" INSERT TB_CONTENTS ( TITLE, SUMMARY, CREATE_DT, CREATE_USER_NM, TAGS, CATEGORY_IDX ) ");
            sbSQL.Append(
                string.Format(" VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}' )",
                    txtTitle.Text, 
                    txtSummary.Text, 
                    DateTime.Now.ToString("yyyy-MM-dd"), 
                    txtUserNm.Text, 
                    txtTags.Text, 
                    2
                )
            );

            ms.Insert(sbSQL.ToString());

            Response.Redirect("Default.aspx");
        }
    }
}