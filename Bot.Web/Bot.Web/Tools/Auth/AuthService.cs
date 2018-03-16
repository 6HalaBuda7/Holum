using Bots.Common.RequestProcessors.Base;

namespace Bot.Web.Tools.Auth
{
	public class AuthService: IBotAuthService
	{
		public bool IsAuthBotRequest(string requestToken)
		{
			var eventsBotToken = "botToken";
			return !string.IsNullOrEmpty(eventsBotToken) && requestToken == eventsBotToken;
		}
	}
}