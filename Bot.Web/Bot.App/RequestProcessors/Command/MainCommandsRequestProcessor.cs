using Bots.Common.RequestProcessors.Base;
using Bots.Common.RequestProcessors.Commands;

namespace Bot.App.RequestProcessors.Command
{
	public class MainCommandsRequestProcessor: BaseRequestProcessor
	{
		public MainCommandsRequestProcessor(IBotAuthService authService, BaseCommandRequestProcessor commandRequestProcessor) : base(authService)
		{
		    SetRequestProcessor(commandRequestProcessor);
		}
	}
}