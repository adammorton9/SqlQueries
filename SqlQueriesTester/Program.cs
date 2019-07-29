using System;
using SqlQueries;

namespace SqlQueriesTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var queryBuilder = new SqlQueryBuilder())
            {
                var query = queryBuilder
                    .Select(
                        ("c", "id").As("CompanyID"),
                        ("c", "CompanyName"),
                        ("u", "Id").As("UserID"))
                    .From("Companies", "c")
                    .WithNoLock()
                    .Join("Users", "u")
                        .On(("u", "Name").IsEqualTo(("c", "UserName")))
                    .Where(
                        ("u","id").IsEqualTo(4)
                        .And(("c","CompanyName").IsEqualTo("'Test'")));
                Console.WriteLine(query.ToString());
                Console.ReadKey();
            }
        }
    }
}
