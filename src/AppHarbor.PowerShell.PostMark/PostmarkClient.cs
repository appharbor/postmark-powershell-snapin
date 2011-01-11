using System.Management.Automation;
using PM = PostmarkDotNet;

namespace AppHarbor.PowerShell.Postmark.Commands
{
	[Cmdlet(VerbsCommon.Get, "PostmarkClient")]
	public class PostmarkClient : Cmdlet
	{
		private PM.PostmarkClient postmarkClient;

		[Parameter(Position = 0)]
		[ValidateNotNullOrEmpty]
		public string ServerToken
		{
			get;
			set;
		}

		protected override void ProcessRecord()
		{
			postmarkClient = new PM.PostmarkClient(ServerToken);
			WriteObject(postmarkClient);
		}

		public PM.PostmarkResponse SendEmail(PM.PostmarkMessage message)
		{
			return postmarkClient.SendMessage(message);
		}
	}
}
