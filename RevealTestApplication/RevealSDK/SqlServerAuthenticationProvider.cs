using Infragistics.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevealTestApplication.RevealSDK
{
    public class SqlServerAuthenticationProvider : IRVAuthenticationProvider
    {
        public Task<IRVDataSourceCredential> ResolveCredentialsAsync(string userId, RVDashboardDataSource dataSource)
        {
            RVUsernamePasswordDataSourceCredential userCredential = null;
            if (dataSource is RVSqlServerDataSource)
            {
                userCredential = new RVUsernamePasswordDataSourceCredential("username", "password", "domain"); // Provide credentials
            }

            return Task.FromResult<IRVDataSourceCredential>(userCredential);
        }
    }
}
