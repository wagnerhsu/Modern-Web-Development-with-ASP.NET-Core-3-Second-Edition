﻿using Microsoft.Extensions.Configuration;
using Microsoft.Win32;

namespace RegistryProvider
{
    public sealed class RegistryConfigurationSource : IConfigurationSource
    {
        public RegistryHive Hive { get; set; } = RegistryHive.CurrentUser;

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new RegistryConfigurationProvider(this);
        }
    }
}