using System;
using System.Collections.Generic;
using System.Text;
using Tes.Model;
using  Tes.DAL;

namespace Tes.BLL
{
	/// <summary>
	/// SensorBLL��
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��03��26�� 10:00:27
	/// </summary>
	public class SensorBLL
	{


		/// <summary>
		/// ��ȡ������Ϣ����
		/// </summary>
		/// <returns>List����</returns>
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
		/// ���� ���� ��ȡһ��ʵ�����
		/// <param name="DataID">����</param>
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
        //����ʱ���ȡ����
        /// <summary>
        /// �����ڻ�ȡ����
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
        /// �������
        /// </summary>
        /// <param name="info">���ݱ�ʵ�����</param>
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
		/// ��������ɾ��һ������
		/// </summary>
		/// <param name="_DataID">����</param>
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

		/// ��������
		/// </summary>
		/// <param name="info">���ݱ�ʵ��</param>
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
