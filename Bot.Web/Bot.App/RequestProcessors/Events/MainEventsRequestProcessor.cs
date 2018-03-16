using Bots.Common.RequestProcessors.Base;
using Bots.Common.RequestProcessors.Events;

namespace Bot.App.RequestProcessors.Events
{
	public class MainEventsRequestProcessor: BaseRequestProcessor
	{
		public MainEventsRequestProcessor(IBotAuthService authService, BaseEventsRequestProcessor eventsRequestProcessor) : base(authService)
		{
		    SetRequestProcessor(eventsRequestProcessor);
		}
	}
}