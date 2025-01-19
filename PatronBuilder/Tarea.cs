namespace PatronBuilder;
// Tarea: crear un QueryBuilder para construir consultas SQL

/**
 * Debe de tener los siguientes métodos:
 * - constructor(table: string)
 * - select(fields: string[]): QueryBuilder -- si no se pasa ningún campo, se seleccionan todos con el (*)
 * - where(condition: string): QueryBuilder - opcional
 * - orderBy(field: string, order: string): QueryBuilder - opcional
 * - limit(limit: number): QueryBuilder - opcional
 * - execute(): string - retorna la consulta SQL
 *

 ** Ejemplo de uso:
  const usersQuery = new QueryBuilder("users") // users es el nombre de la tabla
    .select("id", "name", "email")
    .where("age > 18")
    .where("country = 'Cri'")
    .orderBy("name", "ASC")
    .limit(10)
    .execute();

  console.log('Consulta: ', usersQuery);
  // Select id, name, email from users where age > 18 and country = 'Cri' order by name ASC limit 10;
 */
public class QueryBuilder(string table)
{
    private string Table { get; } = table;
    private string[] Fields { get; set; } = [];
    private List<string> Conditions { get; } = [];
    private List<string> OrderFields { get; } = [];
    private long? LimitCount { get; set; }

    public QueryBuilder Select(params string[] fields)
    {
        this.Fields = fields;
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        Conditions.Add(condition);
        return this;
    }

    public QueryBuilder OrderBy(string field, string order)
    {
        OrderFields.Add($"{field} {order}");
        return this;
    }

    public QueryBuilder Limit(long limit)
    {
        this.LimitCount = limit;
        return this;
    }

    public string Execute()
    {
        var fields = Fields.Length > 0 ? string.Join(", ", Fields) : "*";
        var conditions = Conditions.Count > 0 ? $"where {string.Join(" and ", Conditions)}" : "";
        var order = OrderFields.Count > 0 ? $" order by {string.Join(" ", OrderFields)}" : "";
        var limit = LimitCount == null ? "" : $" limit {LimitCount}";
        return $"Select {fields} from {Table}{conditions}{order}{limit};";
    }
}