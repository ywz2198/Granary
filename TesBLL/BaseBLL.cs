using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using  Tes.DAL;

namespace Tes.BLL
{
	/// <summary>
	/// BaseBLL类
	/// BY：狂人代码生成器 V1.0
	/// 作者：金属狂人
	/// 日期：2017年04月06日 03:44:58
	/// </summary>
	public class BaseBLL
	{


		/// <summary>
		/// 获取所有信息集合
		/// </summary>
		/// <returns>List集合</returns>
		public static List<BaseInfo> GetBaseInfoList(string where)
		{
			try
			{
				return BaseDAL.GetBaseInfoList(where);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 根据 主键 获取一个实体对象
		/// <param name="GranaryID">主键</param>
		/// </summary>
		public static BaseInfo GetBaseInfoById(int GranaryID)
		{
			try
			{
				return BaseDAL.GetBaseInfoById(GranaryID);
			}
			catch
			{
				throw;
			}
		}

		/// 添加数据
		/// </summary>
		/// <param name="info">数据表实体对象</param>
		public static bool AddBase(BaseInfo info)
		{
			try
			{
				return BaseDAL.AddBase(info);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 根据主键删除一个对象
		/// </summary>
		/// <param name="_GranaryID">主键</param>
		/// <returns></returns>
		public static bool DeleteBaseInfo(BaseInfo info)
		{
			try
			{
				return BaseDAL.DeleteBaseInfo(info);
			}
			catch
			{
				throw;
			}
		}

		/// 更新数据
		/// </summary>
		/// <param name="info">数据表实体</param>
		public static bool UpdateBaseInfo(BaseInfo info)
		{
			try
			{
				return BaseDAL.UpdateBaseInfo(info);
			}
			catch
			{
				throw;
			}
		}
	}
}
