using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter08.Works
{
    public class Exam004
    {
        private readonly string connectionStr =
            string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4}",
                "127.0.0.1", 1433, "testdb", "sa", "test123!@#");

        SqlConnection connection;

        public void Run()
        {
            Console.WriteLine("1: 성적 입력");
            Console.WriteLine("2: 성적 이의제기");
            Console.WriteLine("3: 성적 조회");
            Console.WriteLine("0: 종료");

            connection = new SqlConnection(connectionStr);
            connection.Open();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0) { break; }

                switch (input)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Modify();
                        break;
                    case 3:
                        Read();
                        break;
                    default:
                        Console.WriteLine("잘 못 입력하였습니다.");
                        break;
                }
            }

            connection.Close();
        }

        private void Create()
        {
            Console.Write("학생이름을 입력하세요: ");
            string sName = Console.ReadLine();
            Console.Write("학생학번을 입력하세요: ");
            string sID = Console.ReadLine();
            Console.Write("과목명을 입력하세요: ");
            string subject = Console.ReadLine();
            Console.Write("점수를 입력하세요: ");
            int score = Convert.ToInt32(Console.ReadLine());
            string insertSQL = string.Format(" INSERT INTO TB_GRADE ( S_NAME, S_ID, SUBJECT, SCORE ) VALUES ( '{0}', '{1}', '{2}', '{3}' ) ",
                sName, sID, subject, score);

            using (SqlCommand command = new SqlCommand(insertSQL, connection))
            {
                int activeNumber = command.ExecuteNonQuery();
                Console.WriteLine("영향 받은 데이터 : " + activeNumber);
            }
        }

        private void Modify()
        {
            Console.Write("학생학번을 입력하세요: ");
            string sID = Console.ReadLine();

            string selectSQL = string.Format(" SELECT SUBJECT, SCORE FROM TB_GRADE WHERE S_ID = '{0}' ", sID);

            using (SqlCommand command = new SqlCommand(selectSQL, connection))
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("과목명 : {0}", reader["SUBJECT"]);
                    Console.WriteLine("점수 : {0}", reader["SCORE"]);
                    Console.WriteLine("=====");
                }
                reader.Close();
            }

            Console.Write("수정할 과목명을 입력하세요: ");
            string subject = Console.ReadLine();
            Console.Write("점수를 입력하세요: ");
            int score = Convert.ToInt32(Console.ReadLine());

            string updateSQL = string.Format(" UPDATE TB_GRADE SET SCORE='{0}' WHERE S_ID='{1}' AND SUBJECT='{2}' ",
                    score, sID, subject);

            using (SqlCommand command = new SqlCommand(updateSQL, connection))
            {
                int activeNumber = command.ExecuteNonQuery();
                Console.WriteLine("영향 받은 데이터 : " + activeNumber);
            }
        }

        private void Read()
        {
            string selectSQL = string.Format(" SELECT S_NAME, S_ID, SUBJECT, SCORE FROM TB_GRADE ");

            using (SqlCommand command = new SqlCommand(selectSQL, connection))
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("학생이름 : {0}", reader["S_NAME"]);
                    Console.WriteLine("학생학번 : {0}", reader["S_ID"]);
                    Console.WriteLine("과목명 : {0}", reader["SUBJECT"]);
                    Console.WriteLine("점수 : {0}", reader["SCORE"]);
                    Console.WriteLine("=====");
                }
                reader.Close();
            }
        }
    }
}
