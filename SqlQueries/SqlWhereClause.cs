using System;
using System.Collections.Generic;
using System.Text;

namespace SqlQueries
{
    public class SqlWhereClause
    {
        internal string WhereClause;

        public SqlWhereClause()
        {

        }
        public SqlWhereClause(string whereClause)
        {
            WhereClause = whereClause;
        }
    }
}
