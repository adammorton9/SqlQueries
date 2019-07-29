using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlQueries
{
    public class SqlQueryBuilder : IDisposable
    {
        public SqlQueryBuilder()
        {
            
        }

        public SqlSelect Select(params string[] columnNames)
        {
            var queryString = string.Empty;
            for (var i = 0; i < columnNames.Length; i++)
            {
                queryString += columnNames[i];
                if (i + 1 < columnNames.Length)
                {
                    queryString += ", ";
                }
            }

            return new SqlSelect($"SELECT {queryString} FROM ");
        }

        public SqlSelect Select(params ValueTuple<string, string>[] columnNames)
        {
            var queryString = string.Empty;
            for (var i = 0; i < columnNames.Length; i++)
            {
                queryString += $"{columnNames[i].Item1}.{columnNames[i].Item2}";
                if (i + 1 < columnNames.Length)
                {
                    queryString += ", ";
                }
            }

            return new SqlSelect($"SELECT {queryString} FROM ");
        }

        public void Dispose()
        {
            
        }
    }
}
