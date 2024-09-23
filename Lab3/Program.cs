using Lab3;
using Lab3.QueryBuilders;

IQueryBuilder postgresBuilder = new PostgresQueryBuilder();
var director = new QueryDirector(postgresBuilder);

var complexPostgresQuery = director.BuildComplexQuery("users", "age > 20", 10);
Console.WriteLine("Postgres Complex Query:");
Console.WriteLine(complexPostgresQuery);


IQueryBuilder mysqlBuilder = new MySQLQueryBuilder();
director = new QueryDirector(mysqlBuilder);

var complexMySqlQuery = director.BuildComplexQuery("items", "price < 100", 5);
Console.WriteLine("MySQL Complex Query:");
Console.WriteLine(complexMySqlQuery);