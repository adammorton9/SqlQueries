using System;
using System.Collections.Generic;
using System.Text;

namespace SqlQueries
{
    public class SqlJoin
    {
        private readonly string _currentQuery;

        public SqlJoin(string currentQuery)
        {
            _currentQuery = currentQuery;
        }

        public SqlQuery On(string joinOnStatement)
        {
            return new SqlQuery($"{_currentQuery} ON {joinOnStatement} ");
        }
    }
}
