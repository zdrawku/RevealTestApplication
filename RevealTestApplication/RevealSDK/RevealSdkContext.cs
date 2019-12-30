using Infragistics.Sdk;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace RevealTestApplication.RevealSDK
{
    public class RevealSdkContext : IRevealSdkContext
    {
        // In-memory provider
        //public IRVDataSourceProvider DataSourceProvider => new InMemoryDataSourceProvider();
        // In-memory data provider
        //public IRVDataProvider DataProvider => new InMemoryDataProvider();

        // Local Data source provider for LocalDataSource
        //public IRVDataSourceProvider DataSourceProvider => new LocalDataSourceProvider();
        // Local Data provider for LocalDataSource
        //public IRVDataProvider DataProvider => null;

        public IRVDataSourceProvider DataSourceProvider => new SqlServerDataSourceProvider();
        public IRVDataProvider DataProvider => null;
        public IRVAuthenticationProvider AuthenticationProvider => new SqlServerAuthenticationProvider();
        
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
