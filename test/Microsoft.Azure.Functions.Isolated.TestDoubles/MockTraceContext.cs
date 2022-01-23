using Microsoft.Azure.Functions.Worker;

namespace Microsoft.Azure.Functions.Isolated.TestDoubles;
class DefaultTraceContext : TraceContext
{
    public DefaultTraceContext(string traceParent, string traceState)
    {
        TraceParent = traceParent;
        TraceState = traceState;
    }

    public override string TraceParent { get; }

    public override string TraceState { get; }
}