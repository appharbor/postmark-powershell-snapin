using System.Management.Automation;

namespace AppHarbor.PowerShell.Postmark.Commands
{
	class PostmarkSnapIn : PSSnapIn
	{
		public PostmarkSnapIn()
			: base()
		{
		}	

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
				return "This is a snapin that sends email using the Postmark API";
			}
		}
	}
}
