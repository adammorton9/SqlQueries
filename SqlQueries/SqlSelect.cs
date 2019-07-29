using System;
using System.Collections.Generic;
using System.Text;

namespace SqlQueries
{
    public class SqlSelect
    {
        private readonly string _selectQuery;

        public SqlSelect(string selectQuery)
        {
            _selectQuery = selectQuery;
        }

        public SqlQuery From(string tableName)
        {
            return new SqlQuery(_selectQuery + tableName);
        }

        public SqlQuery From(string tableName, string tableAlias)
        {
            return new SqlQuery($"{_selectQuery}{tableName} {tableAlias}");
        }
    }
}
