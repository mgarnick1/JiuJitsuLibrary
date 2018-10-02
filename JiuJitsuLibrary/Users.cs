using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiuJitsuLibrary
{
	public class Users
	{
		public Users()
		{

		}
		private string fullName;

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}
		private string emailAddress;

		public string EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}


	}
}
