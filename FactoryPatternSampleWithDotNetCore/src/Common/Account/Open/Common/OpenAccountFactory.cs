using FactoryPatternSample.Common.Abstraction.Account.Open;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Common.Account.Open.Common {
    public class OpenAccountFactory : IOpenAccountFactory {

        private readonly IServiceProvider serviceProvider;

        public OpenAccountFactory(IServiceProvider serviceProvider) {
            this.serviceProvider = serviceProvider;
        }

        public async Task<IOpenAccountProvider> GetOpenAccountProvider(Type type) {
            IEnumerable<IOpenAccountProvider> providers = serviceProvider.GetService<IEnumerable<IOpenAccountProvider>>();
            IOpenAccountProvider provider = providers.FirstOrDefault(x => x.GetType() == type);
            return await Task.FromResult(provider);
        }
    }
}
