using Lab3.QueryBuilders;

namespace Lab3.QueryBuilders;

public class MySQLQueryBuilder : IQueryBuilder
{
    private string _query;

    public IQueryBuilder Select(string tableName)
    {
        _query = $"SELECT * FROM {tableName}";
        return this;
    }

    public IQueryBuilder Where(string condition)
    {
        _query += $" WHERE {condition}";
        return this;
    }

    public IQueryBuilder Limit(int limit)
    {
        _query += $" LIMIT {limit}";
        return this;
    }

    public string GetSql()
    {
        return _query + ";";
    }
}