using System.Threading.Tasks;
using Bot.App.Commands.Hello;
using Bot.App.Commands.TestPost;
using Bot.App.RequestProcessors.Command;
using Bot.Web.Tools;
using Bot.Web.Tools.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Bot.Web.Controllers
{
	public class CommandsController: Controller
	{
		[HttpPost]
        public async Task<ContentResult> Exec([FromBody]JToken content)
	    {
			var res = await new MainCommandsRequestProcessor(new AuthService(), new CommandsRequestProcessor(new HelloCommand(), new TestPostCommand()))
				.ProcessAsync(content.ToString());
		    return Content(res, "application/json");
	    }
	}
}