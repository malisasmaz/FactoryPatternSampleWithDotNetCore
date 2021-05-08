using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternSample.Model.Account.Open {
    public class OpenAccountResponse {
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
        public string ResultInformation { get; set; }

    }
}
