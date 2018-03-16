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

namespace Bot.App.Commands.Hello
{
	public class HelloCommand: BaseCommand, IHelloCommand
	{
		public override string UniqueName => "hello";
		public override Task<BaseCommandBotResponse<IDiscussCommandResponse>> ExecAsync(BaseCommandBotRequest<DiscussCommandBotRequest> request)
		{
			return Task.FromResult(new BaseCommandBotResponse<IDiscussCommandResponse>
			{
				respType = CommandBotResponseType.StateCommand,
				token = request.token,
				response = new BotCommandStateResponse
				{
					message = "hello",
					state = BotCommandStateType.Success
				}
			});
		}
		public override Task<BaseCommandBotResponse<IMessageCommandResponse>> ExecAsync(BaseCommandBotRequest<MessageCommandBotRequest> request)
		{
			return Task.FromResult(new BaseCommandBotResponse<IMessageCommandResponse>
			{
				respType = CommandBotResponseType.StateCommand,
				token = request.token,
				response = new BotCommandStateResponse
				{
					message = "hello",
					state = BotCommandStateType.Success
				}
			});
		}
		
		public override Task<BaseCommandBotResponse<IEventCommandResponse>> ExecAsync(BaseCommandBotRequest<EventCommandBotRequest> request)
		{
			return Task.FromResult(new BaseCommandBotResponse<IEventCommandResponse>
			{
				respType = CommandBotResponseType.StateCommand,
				token = request.token,
				response = new BotCommandStateResponse
				{
					message = "hello",
					state = BotCommandStateType.Success
				}
			});
		}
	}
}