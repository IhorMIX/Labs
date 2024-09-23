namespace Lab3.QueryBuilders;

public interface IQueryBuilder
{
    IQueryBuilder Select(string tableName);
    IQueryBuilder Where(string condition);
    IQueryBuilder Limit(int limit);
    string GetSql();
}
