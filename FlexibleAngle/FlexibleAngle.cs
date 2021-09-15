using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakamineProduction
{
	/// <summary>保持している角度(double型)を度・ラジアン間で相互変換できる角度クラス</summary>
    public class FlexibleAngle
	{
		private double _degree = 0;
		private double _radian = 0;

		/// <summary>保持している角度を度（°）として扱う</summary>
		public double Degree
		{
			get => _degree;
			set => CalcCore(value, false);
		}

		/// <summary>保持している角度をラジアン（rad）として扱う</summary>
		public double Radian
		{
			get => _radian;
			set => CalcCore(value, true);
		}

		/// <summary>角度変更時、必ず0~359°（Rad換算でおよそ0~PI*2）に収めるようオーバーフローするフラグ</summary>
		public bool IsMinimumContorlled { get; set; }


		private void CalcCore(in double val, bool val_is_rad)
		{
			_degree = _radian = val;

			switch (val)
			{
				case double.NaN:
				case double.PositiveInfinity:
				case double.NegativeInfinity:
					return;	//★　break ではないので注意

				default:
					if (val_is_rad)
						_degree = val * (180 / Math.PI);
					else
						_radian = val * (Math.PI / 180);
					break;
			}

			if (IsMinimumContorlled)
			{
				_degree = _degree % 360;
				if (_degree < 0)
					_degree += 360;
				_radian = _degree * (Math.PI / 180);
			}
		}
		
	}
}
