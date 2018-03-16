using System.Collections.Generic;
using Bot.App.Commands.Hello;
using Bot.App.Commands.TestPost;
using Bots.Common.Models.Command;
using Bots.Common.RequestProcessors.Commands;

namespace Bot.App.RequestProcessors.Command
{
	public class CommandsRequestProcessor: BaseCommandRequestProcessor
	{
		public CommandsRequestProcessor(IHelloCommand helloCommand, ITestPostCommand testPostCommand) 
			: base(new List<ICommand>{helloCommand, testPostCommand})
		{
		}
	}
}