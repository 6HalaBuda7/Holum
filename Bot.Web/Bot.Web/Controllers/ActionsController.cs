using System.Threading.Tasks;
using Bot.App.Actions.Test;
using Bot.App.RequestProcessors.Actions;
using Bot.Web.Tools.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Bot.Web.Controllers
{
	public class ActionsController: Controller
	{
		[HttpPost]
        public async Task<ContentResult> Exec([FromBody]JToken content)
	    {
			var res = await new MainActionsRequestProcessor(new AuthService(), new ActionsRequestProcessor(new TestActionProcessor()))
				.ProcessAsync(content.ToString());
		    return Content(res, "application/json");
	    }
	}
}