using System;
using System.Collections.Generic;
using System.Text;

namespace SqlQueries
{
    public static class SqlColumn
    {
        public static string As(this string columnName, string alias)
        {
            return $"{columnName} {alias}";
        }

        public static ValueTuple<string,string> As(this ValueTuple<string,string> columnName, string alias)
        {
            return new ValueTuple<string,string>(columnName.Item1, $"{columnName.Item2} AS {alias}");
        }

        public static SqlWhereClause IsEqualTo(this string columnName, object value)
        {
            return new SqlWhereClause($"{columnName} = {value} ");
        }

        public static SqlWhereClause IsEqualTo(this ValueTuple<string,string> columnName, object value)
        {
            return new SqlWhereClause($"{columnName.Item1}.{columnName.Item2} = {value} ");
        }

        public static SqlWhereClause IsGreaterThan(this string columnName, object value)
        {
            return new SqlWhereClause();
        }

        public static SqlWhereClause IsLessThan(this string columnName, object value)
        {
            return new SqlWhereClause();
        }

        public static SqlWhereClause IsGreaterThanOrEqualTo(this string columnName, object value)
        {
            return new SqlWhereClause();
        }

        public static SqlWhereClause IsLessThanOrEqualTo(this string columnName, object value)
        {
            return new SqlWhereClause();
        }

        public static SqlWhereClause Like(this string columnName, object value)
        {
            return new SqlWhereClause();
        }

        public static SqlWhereClause In(this string columnName, IEnumerable<object> value)
        {
            return new SqlWhereClause();
        }

        public static SqlWhereClause And(this SqlWhereClause clause, SqlWhereClause newClause)
        {
            clause.WhereClause += $"AND {newClause.WhereClause}";
            return clause;
        }

        public static string IsEqualTo(this ValueTuple<string, string> first,
            ValueTuple<string, string> second)
        {
            return $"{first.Item1}.{first.Item2} = {second.Item1}.{second.Item2}";
        }
    }

    
}
