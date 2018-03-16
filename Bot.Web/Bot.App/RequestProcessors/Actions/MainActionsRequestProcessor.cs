using Bots.Common.RequestProcessors.Actions;
using Bots.Common.RequestProcessors.Base;

namespace Bot.App.RequestProcessors.Actions
{
	public class MainActionsRequestProcessor: BaseRequestProcessor
	{
		public MainActionsRequestProcessor(IBotAuthService authService, BaseActionsRequestProcessor actionsRequestProcessor) : base(authService)
		{
			SetRequestProcessor(actionsRequestProcessor);
		}
	}
}