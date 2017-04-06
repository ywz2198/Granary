using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using  Tes.DAL;

namespace Tes.BLL
{
	/// <summary>
	/// StorageBLL类
	/// BY：狂人代码生成器 V1.0
	/// 作者：金属狂人
	/// 日期：2017年03月26日 01:19:59
	/// </summary>
	public class StorageBLL
	{


		/// <summary>
		/// 获取所有信息集合
		/// </summary>
		/// <returns>List集合</returns>
		public static List<StorageInfo> GetStorageInfoList(string where)
		{
			try
			{
				return StorageDAL.GetStorageInfoList(where);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 根据 主键 获取一个实体对象
		/// <param name="GrainID">主键</param>
		/// </summary>
		public static StorageInfo GetStorageInfoById(int GrainID)
		{
			try
			{
				return StorageDAL.GetStorageInfoById(GrainID);
			}
			catch
			{
				throw;
			}
		}

		/// 添加数据
		/// </summary>
		/// <param name="info">数据表实体对象</param>
		public static bool AddStorage(StorageInfo info)
		{
			try
			{
				return StorageDAL.AddStorage(info);
			}
			catch
			{
				throw;
			}
		}

      
        /// <summary>
        /// 根据主键删除一个对象
        /// </summary>
        /// <param name="_GrainID">主键</param>
        /// <returns></returns>
        public static bool DeleteStorageInfo(StorageInfo info)
		{
			try
			{
				return StorageDAL.DeleteStorageInfo(info);
			}
			catch
			{
				throw;
			}
		}

		/// 更新数据
		/// </summary>
		/// <param name="info">数据表实体</param>
		public static bool UpdateStorageInfo(StorageInfo info)
		{
			try
			{
				return StorageDAL.UpdateStorageInfo(info);
			}
			catch
			{
				throw;
			}
		}
	}
}
