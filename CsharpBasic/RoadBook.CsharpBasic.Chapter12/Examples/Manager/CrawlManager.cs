using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using RoadBook.CsharpBasic.Chapter10.Examples.Manager;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter12.Examples.Manager
{
    public class CrawlManager
    {
        DatabaseInfo _dbInfo;
        MsSqlManager _ms;

        public CrawlManager()
        {
            SetDatabaseInfo();
            SetMsSalManager();
        }

        public void Run()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            List<Model.Contents>  contents = Scan();

            WriteToDocs(contents);

            sw.Stop();
            
            Console.WriteLine("총 " + contents.Count + "건 수집 / 소요시간 : " + sw.Elapsed.ToString());
        }

        private List<Model.Contents> Scan()
        {
            _ms.Open(_dbInfo);

            DataTable dt = _ms.Select("SELECT IDX, TITLE, SUMMARY, CREATE_DT, CREATE_USER_NM, TAGS, LIKE_CNT, CATEGORY_IDX FROM TB_CONTENTS");

            var contents = 
                from dr in dt.AsEnumerable()
                select new Model.Contents()
                {
                    Idx = Convert.ToInt32(dr["IDX"]),
                    Title = dr["TITLE"].ToString(),
                    Summary = dr["SUMMARY"].ToString(),
                    CreateDt = Convert.ToDateTime(dr["CREATE_DT"]),
                    CreateUserNm = dr["CREATE_USER_NM"].ToString(),
                    Tags = dr["TAGS"].ToString()
                };
            
            _ms.Close();

            return contents.ToList();
        }

        private void WriteToDocs(List<Model.Contents> contents)
        {
            XmlManager _xmlManager = new XmlManager(XmlManager.USE_TYPE.WRITE);

            contents.ForEach(c =>
            {
                _xmlManager.Write(c);
            });

            _xmlManager.Save();
        }

        private void SetDatabaseInfo()
        {
            _dbInfo = new DatabaseInfo();
            _dbInfo.Name = "RoadbookDB";
            _dbInfo.Ip = "127.0.0.1";
            _dbInfo.Port = 1433;
            _dbInfo.UserId = "sa";
            _dbInfo.UserPassword = "test123!@#";
        }

        private void SetMsSalManager()
        {
            _ms = new MsSqlManager();
        }
    }
}