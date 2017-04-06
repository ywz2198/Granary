using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Model
{
	/// <summary>
	/// SensorInfo 实体类
	/// BY：狂人代码生成器 V1.0
	/// 作者：金属狂人
	/// 日期：2017年03月26日 10:00:27
	/// </summary>
	public class SensorInfo
	{
		private int _DataID;
		/// <summary>
		/// 获取或设置 DataID 的值
		/// </summary>
		public int DataID
		{
			get { return _DataID; }
			set { _DataID = value; }
		}

		private string _TypeOfSensor;
		/// <summary>
		/// 获取或设置 TypeOfSensor 的值
		/// </summary>
		public string TypeOfSensor
		{
			get { return _TypeOfSensor; }
			set { _TypeOfSensor = value; }
		}

		private int _Granary;
		/// <summary>
		/// 获取或设置 Granary 的值
		/// </summary>
		public int Granary
		{
			get { return _Granary; }
			set { _Granary = value; }
		}

		private int _Group;
		/// <summary>
		/// 获取或设置 Group 的值
		/// </summary>
		public int Group
		{
			get { return _Group; }
			set { _Group = value; }
		}

		private int _Line;
		/// <summary>
		/// 获取或设置 Line 的值
		/// </summary>
		public int Line
		{
			get { return _Line; }
			set { _Line = value; }
		}

		private int _Floor;
		/// <summary>
		/// 获取或设置 Floor 的值
		/// </summary>
		public int Floor
		{
			get { return _Floor; }
			set { _Floor = value; }
		}

		private decimal  _Data;
		/// <summary>
		/// 获取或设置 Data 的值
		/// </summary>
		public decimal  Data
		{
			get { return _Data; }
			set { _Data = value; }
		}

		private string _Time;
		/// <summary>
		/// 获取或设置 Time 的值
		/// </summary>
		public string Time
		{
			get { return _Time; }
			set { _Time = value; }
		}

	}
}
