using Infragistics.Sdk;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace RevealTestApplication.RevealSDK
{
    public class RevealSdkContext : IRevealSdkContext
    {
        public IRVDataSourceProvider DataSourceProvider => new InMemoryDataSourceProvider();

        public IRVDataProvider DataProvider => new InMemoryDataProvider();

        public IRVAuthenticationProvider AuthenticationProvider => null;

        public Task<Stream> GetDashboardAsync(string dashboardId)
        {
            var resourceName = $"RevealTestApplication.Dashboards.{dashboardId}";
            var assembly = Assembly.GetExecutingAssembly();
            return Task.FromResult(assembly.GetManifestResourceStream(resourceName));
        }

        public Task SaveDashboardAsync(string userId, string dashboardId, Stream dashboardStream)
        {
            throw new NotImplementedException();
        }
    }
}
