
namespace Alice.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AliceTableAttribute(string tableName) : Attribute
{
    public readonly string TableName = tableName;
}
