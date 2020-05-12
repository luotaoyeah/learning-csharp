using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace LT.LIB.BOOK.C9N5._04._03._04
{
    /// <summary>
    /// 4.3.4 switching trace levels
    /// </summary>
    public class C01
    {
        /// <summary>
        /// </summary>
        public static void F01()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "appsettings.json", reloadOnChange: true, optional: false)
                .Build();

            var traceSwitch = new TraceSwitch(displayName: "TraceSwitch", description: null);

            configuration
                .GetSection("TraceSwitch")
                .Bind(traceSwitch);

            Debug.WriteLineIf(traceSwitch.TraceError, "ERROR...");
            Debug.WriteLineIf(traceSwitch.TraceWarning, "WARNING...");
            Debug.WriteLineIf(traceSwitch.TraceInfo, "INFO...");
            Debug.WriteLineIf(traceSwitch.TraceVerbose, "VERBOSE...");
        }
    }
}
