using RxjhServer.RxjhServer;
using System.Collections.Generic;

namespace RxjhServer
{
	public class clsItemCraft
	{
		public int 物品ID;

		public string 物品名;

		public int 物品数量;

		public List<clsItemCraftRequired> 需要物品 = new List<clsItemCraftRequired>();

		public int 制作等级;

		public int 制作类型;

		public static List<int> Get制作物品类列表(int 制作类型, int 制作等级)
		{
			List<int> list = new List<int>();
			foreach (clsItemCraft value in World.制作物品列表.Values)
			{
				if (value.制作类型 == 制作类型 && 制作等级 >= value.制作等级)
				{
					list.Add(value.物品ID);
				}
			}
			return list;
		}
	}
}
