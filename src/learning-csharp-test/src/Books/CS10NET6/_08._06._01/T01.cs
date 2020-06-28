using System;
using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace Luotao.Test.Books.CS10NET6._08._06._01
{
    /// <summary>
    ///     8.6.1 working with URIs, DNS, and IP addresses
    /// </summary>
    public class T01
    {
        private readonly ITestOutputHelper testOutputHelper;

        public T01(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void _01()
        {
            var uri = new Uri("http://www.github.com/luotaoyeah?name=luotao");

            Assert.Equal("http", uri.Scheme);
            Assert.Equal(80, uri.Port);
            Assert.Equal("www.github.com", uri.Host);
            Assert.Equal("/luotaoyeah", uri.AbsolutePath);
            Assert.Equal("?name=luotao", uri.Query);
        }

        [Fact]
        public void _02()
        {
            var uri = new Uri("http://www.github.com/luotaoyeah?name=luotao");
            var hostAddresses = Dns.GetHostAddresses(uri.Host);
            foreach (var hostAddress in hostAddresses) testOutputHelper.WriteLine(hostAddress.ToString());

            testOutputHelper.WriteLine("--------------------");

            var ipHostEntry = Dns.GetHostEntry(uri.Host);
            foreach (var ipAddress in ipHostEntry.AddressList) testOutputHelper.WriteLine(ipAddress.ToString());
        }
    }
}
