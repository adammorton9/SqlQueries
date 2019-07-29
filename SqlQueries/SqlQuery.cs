using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlQueries
{
    public class SqlQuery
    {
        private string _query;

        internal SqlQuery()
        {

        }

        public SqlQuery(string query)
        {
            _query = query;
        }
        

        public SqlJoin Join(string tableName, string tableAlias)
        {
            return new SqlJoin($"{_query} JOIN {tableName} {tableAlias} ");
        }

        public SqlQuery Where(SqlWhereClause clause)
        {
            _query += $"WHERE {clause.WhereClause} ";
            return this;
        }

        public override string ToString()
        {
            return _query;
        }

        public SqlQuery WithNoLock()
        {
            _query += " WITH (NOLOCK) ";
            return this;
        }
    }
}
