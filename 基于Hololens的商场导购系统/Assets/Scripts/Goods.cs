using System.Collections.Generic;

//商品类，用于定义商品的信息
class Goods
{
	//商品ID
	public string id;

	//商品名称
	public string name;

	//商品价格
	public double price;

	//商品详细信息
	public string details;

	//相似商品
	public List<string> similarGoods;

	//相关评论
	public List<string> comments;

	//构造函数
	public Goods()
	{
		id = "暂无信息";
		name = "暂无信息";
		price = 0;
		details = "暂无信息";
		similarGoods = null;
		details = null;
	}

	//为ID赋值的构造函数
	public Goods(string id)
	{
		this.id = id;
		name = "暂无信息";
		price = 0;
		details = "暂无信息";
		similarGoods = null;
		details = null;
	}
}
