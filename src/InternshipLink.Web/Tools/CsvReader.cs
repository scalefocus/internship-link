using InternshipLink.Web.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace InternshipLink.Web.Tools
{
    public class CsvReader<T>   //:IDisposeble
    {
        private string[] _firstLine;
        //private Stream stream;

        //public CsvReader(Stream stream)
        //{
        //    this.stream = stream;
        //}
        //~CsvReader()
        //{
        //    Dispose(false);
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //}
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (stream != null)
        //        {
        //            stream.Dispose();
        //        }
        //    }
        //}

        public IEnumerable<T> Read(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var line = reader.ReadLine();
                if (line != null) 
                {
                    _firstLine = SplitLine(line); 
                    while ((line = reader.ReadLine()) != null)
                    {
                        T item = Map(SplitLine(line));
                        yield return item;
                    }
                }

            }

        }

        private T Map(string[] fields)
        {
            var type = typeof(T);
            var props = type.GetProperties();
            throw new NotImplementedException();
        }

        private string[] SplitLine(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException(nameof(line));

            }
            return line.Split(',');
        }
    }  
}