namespace Alice.Code.Entities;

public sealed class AliceSqlColumn<T> where T : struct
{
    public List<T>? WholeColumn
    {
        get
        {
            field = []; // here should be sql request via npgsql to select * from column
            return field;
        }

        private set;
    }
}
