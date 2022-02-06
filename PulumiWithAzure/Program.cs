using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pulumi;

namespace PulumiWithAzure
{
    class Program
    {
        static Task<int> Main() => Deployment.RunAsync<SampleStack>();
    }
}
