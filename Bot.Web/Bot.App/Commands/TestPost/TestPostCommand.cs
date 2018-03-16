using System.Threading.Tasks;
using Bots.Common.ExternelModels.Requests.BotCommands;
using Bots.Common.ExternelModels.Requests.BotCommands.DiscussCommand;
using Bots.Common.ExternelModels.Requests.BotCommands.EventCommand;
using Bots.Common.ExternelModels.Requests.BotCommands.MessageCommand;
using Bots.Common.ExternelModels.Responses.BotCommands;
using Bots.Common.ExternelModels.Responses.BotCommands.DiscussCommand;
using Bots.Common.ExternelModels.Responses.BotCommands.EventCommand;
using Bots.Common.ExternelModels.Responses.BotCommands.MessageCommand;
using Bots.Common.Models.Command;

namespace Bot.App.Commands.TestPost
{
	public class TestPostCommand: BaseCommand, ITestPostCommand
	{
		public override string UniqueName => "TestPostCommand";
		public override Task<BaseCommandBotResponse<IMessageCommandResponse>> ExecAsync(BaseCommandBotRequest<MessageCommandBotRequest> request)
		{
			return Task.FromResult(new BaseCommandBotResponse<IMessageCommandResponse>(CommandBotResponseType.Post,
				new MessageCommandPostBotResponse
				{
					postText = "hello"
				}, request.token));
		}

		public override Task<BaseCommandBotResponse<IDiscussCommandResponse>> ExecAsync(BaseCommandBotRequest<DiscussCommandBotRequest> request)
		{
			return Task.FromResult(new BaseCommandBotResponse<IDiscussCommandResponse>(CommandBotResponseType.Post,
				new DiscussCommandPostBotResponse
				{
					postText = "hello"
				}, request.token));
		}

		public override Task<BaseCommandBotResponse<IEventCommandResponse>> ExecAsync(BaseCommandBotRequest<EventCommandBotRequest> request)
		{
			return Task.FromResult(new BaseCommandBotResponse<IEventCommandResponse>(CommandBotResponseType.Post,
				new EventCommandPostBotResponse
				{
					postText = "hello"
				}, request.token));
		}
	}
}