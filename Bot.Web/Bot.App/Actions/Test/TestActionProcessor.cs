using System.Threading.Tasks;
using Bots.Common.ExternelModels.Requests.BotActions;
using Bots.Common.ExternelModels.Requests.BotActions.Discuss;
using Bots.Common.ExternelModels.Requests.BotActions.Event;
using Bots.Common.ExternelModels.Requests.BotActions.Message;
using Bots.Common.ExternelModels.Responses.BotActions;
using Bots.Common.ExternelModels.Responses.BotActions.Discuss;
using Bots.Common.ExternelModels.Responses.BotActions.Event;
using Bots.Common.ExternelModels.Responses.BotActions.Message;
using Bots.Common.RequestProcessors.Actions;

namespace Bot.App.Actions.Test
{
	public class TestActionProcessor: BaseActionsProcessor
	{
		public override Task<BaseActionsBotResponse<DiscusActionBotResponse>> ProcessAsync(BaseActionsBotRequest<DiscusActionBotRequest> request)
		{
			return Task.FromResult(
				new BaseActionsBotResponse<DiscusActionBotResponse>(new DiscusActionBotResponse
				{
					attachedActions = null,
					message = "OK"
				}, request.token));
		}
		public override Task<BaseActionsBotResponse<EventActionBotResponse>> ProcessAsync(BaseActionsBotRequest<EventActionBotRequest> request)
		{
			return Task.FromResult(
				new BaseActionsBotResponse<EventActionBotResponse>(new EventActionBotResponse
				{
					attachedActions = null,
					message = "OK"
				}, request.token));
		}
		public override Task<BaseActionsBotResponse<MessageActionBotResponse>> ProcessAsync(BaseActionsBotRequest<MessageActionBotRequest> request)
		{
			return Task.FromResult(
				new BaseActionsBotResponse<MessageActionBotResponse>(new MessageActionBotResponse
				{
					attachedActions = null,
					postText = "OK"
				}, request.token));
		}
	}
}