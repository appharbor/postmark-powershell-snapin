using System.Management.Automation;
using PostmarkDotNet;

namespace AppHarbor.PowerShell.Postmark.Commands
{
	[Cmdlet(VerbsCommon.Get, "PostmarkClient")]
	public class PostmarkClientCmdlet : Cmdlet
	{
		[Parameter(Position = 0)]
		[ValidateNotNullOrEmpty]
		public string ServerToken
		{
			get;
			set;
		}

		protected override void ProcessRecord()
		{
			var postmarkClient = new PostmarkClient(ServerToken);
			WriteObject(postmarkClient);
		}
	}
}
