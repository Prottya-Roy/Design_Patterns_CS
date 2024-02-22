using Design_Patterns.Abstract_Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern.Storage_Provider_Example
{
    internal class StorageProviderFactory
    {
        public static IStorageProvider CreateStorageProvider(string providerName)
        {
            switch (providerName.ToLower())
            {
                case "aws":
                    return new AWSProvider();
                case "azure":
                    return new AzureProvider();
                case "googlecloud":
                    return new GoogleCloudProvider();
                default:
                    throw new ArgumentException("Invalid storage provider name");
            }
        }
    }
}
