﻿using System.Configuration;

namespace Stove
{
    public static class ConnectionStringHelper
    {
        /// <summary>
        ///     Gets connection string from given connection string or name.
        /// </summary>
        /// <param name="nameOrConnectionString">The name or connection string.</param>
        /// <returns></returns>
        public static string GetConnectionString(string nameOrConnectionString)
        {
            ConnectionStringSettings connStrSection = ConfigurationManager.ConnectionStrings[nameOrConnectionString];
            if (connStrSection != null)
            {
                return connStrSection.ConnectionString;
            }

            return nameOrConnectionString;
        }
    }
}
