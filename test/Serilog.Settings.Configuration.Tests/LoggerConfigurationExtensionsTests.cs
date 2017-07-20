using Microsoft.Extensions.Configuration;
using System;
using Xunit;

namespace Serilog.Settings.Configuration.Tests
{
    public class LoggerConfigurationExtensionsTests
    {
        [Fact]
        public void ReadFromConfigurationShouldNotThrowOnEmptyConfiguration()
        {
            Action act = () => new LoggerConfiguration().ReadFrom.Configuration(new ConfigurationBuilder().Build());

            // should not throw
            act();
        }

#if NET452
        [Fact(Skip = "EntryAssembly is null on this platform due to https://github.com/Microsoft/vstest/issues/649")]
#else
        [Fact]
#endif
        public void DefaultDependencyContextShouldNotBeNull()
        {
            Assert.NotNull(ConfigurationLoggerConfigurationExtensions.GetDefaultDependencyContext());
        }
    }
}
