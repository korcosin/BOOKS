using System;
using System.IO;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Documents;
using Lucene.Net.Store;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.QueryParsers;

namespace RoadBook.CsharpBasic.Chapter12.Examples
{
    public class StemAnalyzer : Analyzer
    {
        public override TokenStream TokenStream(string fieldName, TextReader reader)
        {
            return new PorterStemFilter(new StandardTokenizer(Lucene.Net.Util.Version.LUCENE_30, reader));
        }
    }

    public class Ex002
    {
        string indexPath = Environment.CurrentDirectory + "\\LuceneIndex";
        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;

        System.Collections.Generic.List<Document> _docs;
        Lucene.Net.Store.Directory _directory;
        Analyzer _analyzer;

        public void Run()
        {
            Crawl();
            Index();

            Search("csharp");
            Search("program");
        }

        private void Crawl()
        {
            System.Collections.Generic.List<Model.Book> bookList = new System.Collections.Generic.List<Model.Book>()
            {
                new Model.Book { Id = "P001", Title = "Csharp Programming Basic", Description = "C# 초급자들을 위한 기본서", Price = 35000 },
                new Model.Book { Id = "P002", Title = "Csharp Programming Advance", Description = "C# 고급자들을 위한 고급기술 서적", Price = 40000 },
                new Model.Book { Id = "P003", Title = "Java Programming With Lambda", Description = "Lambda Expression을 이용한 자바 프로그래밍", Price = 27000 },
                new Model.Book { Id = "P004", Title = "Data Science With Python", Description = "파이썬을 이용한 데이터 사이언스", Price = 48000 },
                new Model.Book { Id = "P005", Title = "Apache Lucene", Description = "검색엔진 구축을 위한 Lucene", Price = 25000 },
                new Model.Book { Id = "P006", Title = "MS-SQL Database Management", Description = "MS-SQL 관리", Price = 32000 }
            };

            _docs = new System.Collections.Generic.List<Document>();
            foreach (var book in bookList)
            {
                var data = new Document();
                data.Add(new Field("ID", book.Id, Field.Store.YES, Field.Index.NOT_ANALYZED));
                data.Add(new Field("TITLE", book.Title, Field.Store.YES, Field.Index.ANALYZED));
                data.Add(new Field("DESCRIPTION", book.Description, Field.Store.YES, Field.Index.ANALYZED));
                data.Add(new Field("PRICE", book.Price.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));

                _docs.Add(data);
            }
        }

        private void Index()
        {
            _directory = FSDirectory.Open(new DirectoryInfo(indexPath));

            //_analyzer = new StandardAnalyzer(luceneVersion);
            _analyzer = new StemAnalyzer();

            using (var writer = new IndexWriter(_directory, _analyzer, true, IndexWriter.MaxFieldLength.LIMITED))
            {
                foreach (var doc in _docs)
                {
                    writer.AddDocument(doc);
                }
                writer.Optimize();
            }
        }

        private void Search(string q)
        {
            IndexReader indexReader = IndexReader.Open(_directory, true);
            Searcher indexSearch = new IndexSearcher(indexReader);

            var queryParser = new MultiFieldQueryParser(luceneVersion, new string[] { "TITLE", "DESCRIPTION" }, _analyzer);
            var query = queryParser.Parse(q);

            Console.WriteLine("[검색어] {0}", query);

            TopDocs resultDocs = indexSearch.Search(query, indexReader.MaxDoc);

            var hits = resultDocs.ScoreDocs;

            int currentRow = 0;
            foreach (var hit in hits)
            {
                var documentFromSearch = indexSearch.Doc(hit.Doc);
                Console.WriteLine("* Result {0}", ++currentRow);
                Console.WriteLine("\t-도서명 : {0}", documentFromSearch.Get("TITLE"));
                Console.WriteLine("\t-요약 : {0}", documentFromSearch.Get("DESCRIPTION"));
                Console.WriteLine("\t-가격 : {0}", documentFromSearch.Get("PRICE"));
            }

            Console.WriteLine();
        }
    }
}