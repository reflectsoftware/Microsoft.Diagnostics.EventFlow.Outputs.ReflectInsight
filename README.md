# Microsoft.Diagnostics.EventFlow for ReflectInsight



## Getting Started
   
The ReflectInsight EventFlow is an extension to the Microsoft.Diagnostics.EventFlow set of Output sources. 

More information can be found here: [**Microsoft.Diagnostics.EventFlow**](https://github.com/Azure/diagnostics-eventflow/)




#### ReflectInsight Implementation

*Nuget package:* [**Microsoft.Diagnostics.EventFlow.Outputs.ReflectInsight**](https://www.nuget.org/packages/Microsoft.Diagnostics.EventFlow.Outputs.ReflectInsight/)

All configured input events will be captured and sent to [ReflectInsight](https://reflectsoftware.com/), which in turn redirects them to one or more configured destinations (i.e. Live Viewer, etc.).

*Configuration example*

```json
{
  "type": "ReflectInsight",
  "instanceName": "myInstance"
}

```

Supported configuration settings are:

| Field | Values/Types | Required | Description |
| :---- | :-------------- | :------: | :---------- |
| `type` | "ReflectInsight" | Yes | Specifies the output type. For this output, it must be "ReflectInsight". |
| `instanceName` | string | No | The name of the Instance to used configured in the ReflectInsight.config file, if any. |


*Example: In this example, Trace is assumed as one of the Input sources*

```csharp
using Microsoft.Diagnostics.EventFlow;
using System;

namespace EventFlowReflectInsightConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json"))
            {
                // In this example, Trace is assumed as one of the Input sources.
                System.Diagnostics.Trace.TraceWarning("EventFlow is working!");
                System.Diagnostics.Trace.TraceError("EventFlow is working!");
                Console.ReadLine();
            }
        }
    }
}
```

## Platform Support
EventFlow supports full .NET Framework (.NET 4.5 series and 4.6 series) and .NET Core, but not all inputs and outputs are supported on all platforms. 
The following table lists platform support for standard inputs and outputs.  

| Input Name | .NET 4.5.1 | .NET 4.6 | .NET Core |
| :------------ | :---- | :---- | :---- |
| *Outputs* |
| [ReflectInsight](#reflectinsight) | Yes | Yes | No |

