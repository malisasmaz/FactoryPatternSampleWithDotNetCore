using FactoryPatternSample.Common.Abstraction.Account.Open;
using FactoryPatternSample.Common.Account.Open.TL;
using FactoryPatternSample.Model.Account.Open;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Library.Account.Open {
    public class OpenAccountPageInfoHandler {
        private readonly IOpenAccountFactory openAccountFactory;

        public OpenAccountPageInfoHandler(IOpenAccountFactory openAccountFactory) {
            this.openAccountFactory = openAccountFactory;
        }

        public async Task<OpenAccountResponse> Run(OpenAccountRequest request) {
            var response = new OpenAccountResponse();

            Type accountType = request.ScreenType switch
            {
                "TL" => typeof(OpenTLAccountProvider),
                "USD" => typeof(OpenUSDAccountProvider),
                _ => throw new InvalidOperationException("Invalid ScreenType")
            };

            IOpenAccountProvider provider = await openAccountFactory.GetOpenAccountProvider(accountType);

            return provider.Get(request, response); ;
        }
    }
}
