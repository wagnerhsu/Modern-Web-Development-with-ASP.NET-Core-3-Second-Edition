﻿using Microsoft.Extensions.Configuration;
using Microsoft.Win32;

namespace RegistryProvider
{
    public static class RegistryConfigurationExtensions
    {
        public static IConfigurationBuilder AddRegistry(this IConfigurationBuilder builder, RegistryHive hive = RegistryHive.CurrentUser)
        {
            return builder.Add(new RegistryConfigurationSource { Hive = hive });
        }
    }
}
