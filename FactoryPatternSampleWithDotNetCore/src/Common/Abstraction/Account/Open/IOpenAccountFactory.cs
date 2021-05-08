using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Common.Abstraction.Account.Open {
    public interface IOpenAccountFactory {
        Task<IOpenAccountProvider> GetOpenAccountProvider(Type type);
    }
}
