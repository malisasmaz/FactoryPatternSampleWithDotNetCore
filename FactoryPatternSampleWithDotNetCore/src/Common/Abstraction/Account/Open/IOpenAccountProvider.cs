using FactoryPatternSample.Model.Account.Open;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Common.Abstraction.Account.Open {
    public interface IOpenAccountProvider {
        OpenAccountResponse Get(OpenAccountRequest request, OpenAccountResponse response);
        OpenAccountResponse Post(OpenAccountRequest request, OpenAccountResponse response);

    }
}
