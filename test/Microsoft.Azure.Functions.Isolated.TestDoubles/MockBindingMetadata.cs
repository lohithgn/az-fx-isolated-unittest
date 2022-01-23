using Microsoft.Azure.Functions.Worker;

namespace Microsoft.Azure.Functions.Isolated.TestDoubles;
public class MockBindingMetadata : BindingMetadata
{
    public MockBindingMetadata(string type, BindingDirection direction)
    {
        Type = type;
        Direction = direction;
    }

    public override string Type { get; }

    public override BindingDirection Direction { get; }
}
