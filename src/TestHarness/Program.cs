using Microsoft.Diagnostics.EventFlow;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json"))
            {
                // In this example, Trace is assumed as one of the Input sources.
                System.Diagnostics.Trace.TraceInformation("EventFlow is working - Information!");
                System.Diagnostics.Trace.TraceWarning("EventFlow is working - Warning!");
                System.Diagnostics.Trace.TraceError("EventFlow is working - Error!");
                // Console.ReadLine();
            }
        }
    }
}
