using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Works
{
    public class Exam004
    {
        public void Run()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var tbUser = context.TB_USER.Where(u => u.ID == "U002").First();

                tbUser.AGE = 30;
                context.SubmitChanges();
            }
        }
    }
}
