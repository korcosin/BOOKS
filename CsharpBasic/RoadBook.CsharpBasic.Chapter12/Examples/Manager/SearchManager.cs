using Lucene.Net.QueryParsers;
using System;

namespace RoadBook.CsharpBasic.Chapter12.Examples.Manager
{
    public class SearchManager
    {
        private static char directorySeparator = System.IO.Path.DirectorySeparatorChar;
        string _indexDirectoryPath = Environment.CurrentDirectory + directorySeparator + "indexer";

        Lucene.Net.Store.Directory _directory;
        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;
        Lucene.Net.Analysis.Analyzer _analyzer;

        public SearchManager()
        {
            _directory = Lucene.Net.Store.FSDirectory.Open(new System.IO.DirectoryInfo(_indexDirectoryPath));
            _analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(luceneVersion);
        }

        public void Run()
        {
            Lucene.Net.Index.IndexReader indexReader = Lucene.Net.Index.IndexReader.Open(_directory, true);
            Lucene.Net.Search.Searcher indexSearch = new Lucene.Net.Search.IndexSearcher(indexReader);

            var queryParser = new QueryParser(luceneVersion, "TAGS", _analyzer);

            Console.Write("검색어를 입력해주세요 :");
            string q = Console.ReadLine();

            var query = queryParser.Parse(q);

            Console.WriteLine("[검색어] {0}", q);

            Lucene.Net.Search.TopDocs resultDocs = indexSearch.Search(query, indexReader.MaxDoc);

            var hits = resultDocs.ScoreDocs;

            int currentRow = 0;
            foreach (var hit in hits)
            {
                var documentFromSearch = indexSearch.Doc(hit.Doc);
                Console.WriteLine("* Result {0}", ++currentRow);
                Console.WriteLine("\t-제목 : {0}", documentFromSearch.Get("TITLE"));
                Console.WriteLine("\t-내용 : {0}", documentFromSearch.Get("SUMMARY"));
                Console.WriteLine("\t-태그 : {0}", documentFromSearch.Get("TAGS"));
            }

            Console.WriteLine();
        }
    }
}