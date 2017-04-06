using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using  Tes.DAL;

namespace Tes.BLL
{
	/// <summary>
	/// SensorBLL类
	/// BY：狂人代码生成器 V1.0
	/// 作者：金属狂人
	/// 日期：2017年03月26日 10:00:27
	/// </summary>
	public class SensorBLL
	{


		/// <summary>
		/// 获取所有信息集合
		/// </summary>
		/// <returns>List集合</returns>
		public static List<SensorInfo> GetSensorInfoList(string where)
		{
			try
			{
				return SensorDAL.GetSensorInfoList(where);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 根据 主键 获取一个实体对象
		/// <param name="DataID">主键</param>
		/// </summary>
		public static SensorInfo GetSensorInfoById(int DataID)
		{
			try
			{
				return SensorDAL.GetSensorInfoById(DataID);
			}
			catch
			{
				throw;
			}
		}
        //根据时间获取数据
        /// <summary>
        /// 用日期获取数据
        /// </summary>
        /// <param name="datetime1"></param>
        /// <param name="datetime2"></param>
        /// <returns></returns>
        public static List<SensorInfo> GetDataByDatetime(DateTime datetime1, DateTime datetime2)
        {
            try
            {
                return SensorDAL.GetDataByDatetime(datetime1, datetime2);
                
            }
            catch
            {
                throw;
            }
        }
        /// 添加数据
        /// </summary>
        /// <param name="info">数据表实体对象</param>
        public static bool AddSensor(SensorInfo info)
		{
			try
			{
				return SensorDAL.AddSensor(info);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// 根据主键删除一个对象
		/// </summary>
		/// <param name="_DataID">主键</param>
		/// <returns></returns>
		public static bool DeleteSensorInfo(SensorInfo info)
		{
			try
			{
				return SensorDAL.DeleteSensorInfo(info);
			}
			catch
			{
				throw;
			}
		}

		/// 更新数据
		/// </summary>
		/// <param name="info">数据表实体</param>
		public static bool UpdateSensorInfo(SensorInfo info)
		{
			try
			{
				return SensorDAL.UpdateSensorInfo(info);
			}
			catch
			{
				throw;
			}
		}
	}
}
