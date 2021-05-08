using FactoryPatternSample.Common.Abstraction.Account.Open;
using FactoryPatternSample.Common.Account.Open.Common;
using FactoryPatternSample.Model.Account.Open;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Common.Account.Open.TL {
    public partial class OpenTLAccountProvider : BaseOpenAccount, IOpenAccountProvider {
        public OpenAccountResponse Get(OpenAccountRequest request, OpenAccountResponse response) {
            return new OpenAccountResponse { ResultInformation = "TL account infos" };
        }
    }
}
