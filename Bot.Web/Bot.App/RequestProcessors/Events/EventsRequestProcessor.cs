using Bots.Common.RequestProcessors.Events;

namespace Bot.App.RequestProcessors.Events
{
	public class EventsRequestProcessor: BaseEventsRequestProcessor
	{
		public EventsRequestProcessor(IEventsProcessor eventsProcessor) : base(eventsProcessor)
		{
		}
	}
}