using System.Management.Automation;
using PM = PostmarkDotNet;

namespace AppHarbor.PowerShell.Postmark.Commands
{
	[Cmdlet("Send", "PostmarkEmail")]
	public class SendEmail : Cmdlet
	{
		protected override void ProcessRecord()
		{
			var message = new PM.PostmarkMessage
			{
				From = From,
				To = To,
				Subject = Subject,
				HtmlBody = HtmlBody,
				TextBody = TextBody,
				ReplyTo = ReplyTo,
			};
			var response = PostmarkClient.SendMessage(message);
			WriteObject(response);
		}

		[Parameter(ValueFromPipeline = true)]
		[ValidateNotNullOrEmpty]
		public PM.PostmarkClient PostmarkClient
		{
			get;
			set;
		}

		[Parameter(Position = 1)]
		[ValidateNotNullOrEmpty]
		public string From
		{
			get;
			set;
		}

		[Parameter(Position = 2)]
		[ValidateNotNullOrEmpty]
		public string To
		{
			get;
			set;
		}

		[Parameter(Position = 3)]
		[ValidateNotNullOrEmpty]
		public string Subject
		{
			get;
			set;
		}

		[Parameter(Position = 4)]
		public string HtmlBody
		{
			get;
			set;
		}

		[Parameter(Position = 5)]
		[ValidateNotNullOrEmpty]
		public string TextBody
		{
			get;
			set;
		}

		[Parameter(Position = 6)]
		public string ReplyTo
		{
			get;
			set;
		}
	}
}
