using System.Collections.Generic;
using System.Threading.Tasks;
using Bots.ApiLayer.Api.Discuss;
using Bots.ApiLayer.Api.Message;
using Bots.ApiLayer.Models.AttachmentEntity;
using Bots.ApiLayer.Models.AttachmentEntity.Forms;
using Bots.ApiLayer.Models.AttachmentEntity.Views;
using Bots.ApiLayer.Models.Message.Forms;
using Bots.ApiLayer.Models.Post;
using Bots.Common.ExternelModels.Requests.BotEvents;
using Bots.Common.ExternelModels.Requests.BotEvents.PostGroupDiscuss;
using Bots.Common.ExternelModels.Requests.BotEvents.PostGroupEvent;
using Bots.Common.ExternelModels.Responses.BotEvents;
using Bots.Common.ExternelModels.Responses.BotEvents.PostGroupDiscuss;
using Bots.Common.RequestProcessors.Events;

namespace Bot.App.Events
{
	public class EventsProcessor: BaseEventsProcessor
	{
		public override Task<BaseEventsBotResponse<PostGroupDicussResponse>> ProcessAsync(BaseEventsBotRequest<PostGroupDicussRequest> request)
		{
			return Task.FromResult(
				new BaseEventsBotResponse<PostGroupDicussResponse>(new PostGroupDicussResponse
				{
					postText = "I am bot!",
					attachedActions = new List<AttachmentEntityCreateForm>
					{
						new AttachmentEntityCreateForm
						{
							title = "Would you like to create a bot?",
							type = AttachmentEntityType.Regular,
							uid = "yourUid",
							actions = new List<AttachmentEntityActionCreateForm>
							{
								new AttachmentEntityActionCreateForm
								{
									type = AttachmentEntityActionType.Button,
									uid = "yourUid",
									data = new AttachmentEntityActionButtonView
									{
										style = AttachmentEntityActionButtonStyle.Success,
										text = "Yes"
									}
								},
								new AttachmentEntityActionCreateForm
								{
									type = AttachmentEntityActionType.Button,
									uid = "yourUid1",
									data = new AttachmentEntityActionButtonView
									{
										style = AttachmentEntityActionButtonStyle.Normal,
										text = "No"
									}
								}
							}
						}
					}
				}, request.token));
		}

		public override async Task<BaseEventsBotResponse<PostGroupDicussResponse>> ProcessAsync(BaseEventsBotRequest<PostGroupEventRequest> arg)
		{
			await new MessageApi("botToken").BotPostAsync(new BotPostMessageForm
			{
				postText = arg.request.message,
				corsWmid = new List<string>{"wmid"}
			});
			return null;
		}

		//override the other events
	}
}