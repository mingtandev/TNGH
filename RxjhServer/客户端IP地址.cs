namespace RxjhServer
{
	public class 客户端IP地址
	{
		private string _ID;

		private string _MAC地址;

		private string _内网IP地址;

		private string _外网IP地址;

		public string ID
		{
			get
			{
				return _ID;
			}
			set
			{
				_ID = value;
			}
		}

		public string MAC地址
		{
			get
			{
				return _MAC地址;
			}
			set
			{
				_MAC地址 = value;
			}
		}

		public string 内网IP地址
		{
			get
			{
				return _内网IP地址;
			}
			set
			{
				_内网IP地址 = value;
			}
		}

		public string 外网IP地址
		{
			get
			{
				return _外网IP地址;
			}
			set
			{
				_外网IP地址 = value;
			}
		}

		public 客户端IP地址(string id, string Nip, string Wip, string MAC)
		{
			ID = id;
			内网IP地址 = Nip;
			外网IP地址 = Wip;
			MAC地址 = MAC;
		}
	}
}
