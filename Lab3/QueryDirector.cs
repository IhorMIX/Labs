using Lab3.QueryBuilders;

namespace Lab3;

public class QueryDirector
{
    private readonly IQueryBuilder _builder;

    public QueryDirector(IQueryBuilder builder)
    {
        _builder = builder;
    }
    public string BuildComplexQuery(string tableName, string condition, int limit)
    {
        return _builder
            .Select(tableName)
            .Where(condition)
            .Limit(limit)
            .GetSql();
    }
}
