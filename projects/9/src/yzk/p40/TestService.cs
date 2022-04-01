using Microsoft.Extensions.Options;

namespace P40;

public class TestService
{
    /// <summary>
    /// IOptions / IOptionsSnapshot / IOptionsMonitor 三种方式的区别.
    /// </summary>
    private readonly IOptions<Config> configOptions;

    private readonly IOptionsSnapshot<Proxy> proxyOptions;

    public TestService(IOptions<Config> configOptions, IOptionsSnapshot<Proxy> proxyOptions)
    {
        this.configOptions = configOptions;
        this.proxyOptions = proxyOptions;
    }

    public Config GetConfig()
    {
        return configOptions.Value;
    }

    public Proxy GetProxy()
    {
        return proxyOptions.Value;
    }
}
