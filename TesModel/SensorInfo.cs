using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Model
{
	/// <summary>
	/// SensorInfo ʵ����
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��03��26�� 10:00:27
	/// </summary>
	public class SensorInfo
	{
		private int _DataID;
		/// <summary>
		/// ��ȡ������ DataID ��ֵ
		/// </summary>
		public int DataID
		{
			get { return _DataID; }
			set { _DataID = value; }
		}

		private string _TypeOfSensor;
		/// <summary>
		/// ��ȡ������ TypeOfSensor ��ֵ
		/// </summary>
		public string TypeOfSensor
		{
			get { return _TypeOfSensor; }
			set { _TypeOfSensor = value; }
		}

		private int _Granary;
		/// <summary>
		/// ��ȡ������ Granary ��ֵ
		/// </summary>
		public int Granary
		{
			get { return _Granary; }
			set { _Granary = value; }
		}

		private int _Group;
		/// <summary>
		/// ��ȡ������ Group ��ֵ
		/// </summary>
		public int Group
		{
			get { return _Group; }
			set { _Group = value; }
		}

		private int _Line;
		/// <summary>
		/// ��ȡ������ Line ��ֵ
		/// </summary>
		public int Line
		{
			get { return _Line; }
			set { _Line = value; }
		}

		private int _Floor;
		/// <summary>
		/// ��ȡ������ Floor ��ֵ
		/// </summary>
		public int Floor
		{
			get { return _Floor; }
			set { _Floor = value; }
		}

		private decimal  _Data;
		/// <summary>
		/// ��ȡ������ Data ��ֵ
		/// </summary>
		public decimal  Data
		{
			get { return _Data; }
			set { _Data = value; }
		}

		private string _Time;
		/// <summary>
		/// ��ȡ������ Time ��ֵ
		/// </summary>
		public string Time
		{
			get { return _Time; }
			set { _Time = value; }
		}

	}
}
