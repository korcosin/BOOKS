using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter12.Examples.Manager
{
    public class IndexManager
    {
        private static readonly char _directorySeparator = System.IO.Path.DirectorySeparatorChar;
        private readonly string _indexDirectoryPath = Environment.CurrentDirectory + _directorySeparator + "indexer";

        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;

        List<Lucene.Net.Documents.Document> _docs;
        Lucene.Net.Store.Directory _directory;
        Lucene.Net.Analysis.Analyzer _analyzer;

        private Manager.XmlManager _xmlManager;

        public IndexManager()
        {
            _xmlManager = new Manager.XmlManager(Manager.XmlManager.USE_TYPE.READ);
        }

        public void Run()
        {
            List<Model.Contents> contentsList = _xmlManager.Read();

            _docs = new List<Lucene.Net.Documents.Document>();
            foreach (var content in contentsList)
            {
                var data = new Lucene.Net.Documents.Document();
                data.Add(new Lucene.Net.Documents.Field("IDX", content.Idx.ToString(), Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("TITLE", content.Title, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("SUMMARY", content.Summary, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("CREATE_DT", content.CreateDt.ToString(), Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("CREATE_USER_NM", content.CreateUserNm, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("TAGS", content.Tags, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.ANALYZED));

                _docs.Add(data);
            }

            _directory = Lucene.Net.Store.FSDirectory.Open(new System.IO.DirectoryInfo(_indexDirectoryPath));

            _analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(luceneVersion);

            using (var writer = new Lucene.Net.Index.IndexWriter(_directory, _analyzer, true, Lucene.Net.Index.IndexWriter.MaxFieldLength.LIMITED))
            {
                foreach (var doc in _docs)
                {
                    writer.AddDocument(doc);
                }
                writer.Optimize();
            }
        }
    }
}