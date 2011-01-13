using System.Management.Automation;

namespace AppHarbor.PowerShell.Postmark.Commands
{
	public class PostmarkSnapIn : PSSnapIn
	{
		public override string Name
		{
			get
			{
				return "AppHarbor.PowerShell.Postmark";
			}
		}

		public override string Vendor
		{
			get
			{
				return "AppHarbor";
			}
		}

		public override string VendorResource
		{
			get
			{
				return "PostmarkSnapIn,AppHarbor";
			}
		}

		public override string Description
		{
			get
			{
				return "This is a snap-in that sends email using the Postmark API";
			}
		}
	}
}
