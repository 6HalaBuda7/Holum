using System.Threading.Tasks;
using Bot.App.Events;
using Bot.App.RequestProcessors.Events;
using Bot.Web.Tools.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Bot.Web.Controllers
{
	public class EventsController: Controller
	{
		[HttpPost]
        public async Task<ContentResult> Fire([FromBody]JToken content)
	    {
			var res = await new MainEventsRequestProcessor(new AuthService(), new EventsRequestProcessor(new EventsProcessor()))
				.ProcessAsync(content.ToString());
		    return Content(res, "application/json");
	    }
	}
}