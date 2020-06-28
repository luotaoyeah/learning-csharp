using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.IO;

namespace Luotao.Lib.Books.CS10NET6._04._03._04
{
    /// <summary>
    ///     4.3.4 switching trace levels
    /// </summary>
    public class C01
    {
        /// <summary>
        /// </summary>
        public static void F01()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: false)
                .Build();

            var traceSwitch = new TraceSwitch("TraceSwitch", null);

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
