using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Works
{
    public class Exam005
    {
        public void Run()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var tbUser = context.TB_USER.Where(u => u.ID == "U009").First();

                context.TB_USER.DeleteOnSubmit(tbUser);
                context.SubmitChanges();
            }
        }
    }
}