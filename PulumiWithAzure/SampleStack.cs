using System;
using Pulumi;
using storage = global::Pulumi.AzureNative.Storage;

namespace PulumiWithAzure
{
    public class SampleStack : Stack
    {
        public SampleStack()
        {
            var config = new Config();
            var rg = config.Require("rg");
            var prefix = config.Require("prefix");

            var sampleStorage = new storage.StorageAccount($"{prefix}mystorage", new storage.StorageAccountArgs
            {
                ResourceGroupName = rg,
                AccountName = $"{prefix}mystorage",
                Kind = storage.Kind.StorageV2,
                Sku = new storage.Inputs.SkuArgs
                {
                    Name = storage.SkuName.Standard_GRS
                }
            });
        }

    }
}