using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Luotao.Test.Books.CS10NET6._04._03._04
{
    /// <summary>
    /// 4.3.4. switching trace levels
    /// </summary>
    public class T01
    {
        [Fact]
        public void _01()
        {
            IConfigurationRoot? configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: false)
                .Build();

            TraceSwitch traceSwitch = new("TraceSwitch", null);

            configuration
                ?.GetSection("TraceSwitch")
                ?.Bind(traceSwitch);

            Trace.WriteLineIf(traceSwitch.TraceError, "ERROR...");
            Trace.WriteLineIf(traceSwitch.TraceWarning, "WARNING...");
            Trace.WriteLineIf(traceSwitch.TraceInfo, "INFO...");
            Trace.WriteLineIf(traceSwitch.TraceVerbose, "VERBOSE...");
        }
    }
}
