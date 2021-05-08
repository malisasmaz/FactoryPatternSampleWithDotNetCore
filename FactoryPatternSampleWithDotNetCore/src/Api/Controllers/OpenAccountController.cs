using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPatternSample.Common.Abstraction.Account.Open;
using FactoryPatternSample.Library.Account.Open;
using FactoryPatternSample.Model.Account.Open;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPatternSampleWithDotNetCore.src.Api.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class OpenAccountController : ControllerBase {
       
        // POST: OpenAccount/Get
        [HttpPost]
        public async Task<OpenAccountResponse> Get([FromBody] OpenAccountRequest request) {

            var services = this.HttpContext.RequestServices;
            var openAccountFactory = (IOpenAccountFactory)services.GetService(typeof(IOpenAccountFactory));
            var handler = new OpenAccountPageInfoHandler(openAccountFactory);
            return await handler.Run(request);

        }
    }
}