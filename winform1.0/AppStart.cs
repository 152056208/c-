using System;
using System.Windows.Forms;

namespace Prana.Notepad
{
	/// <summary>
	/// AppStart ��ժҪ˵����
	/// </summary>
	public class AppStart
	{
		public AppStart()
		{
			// ������www.51aspx.com
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmMain());
		}
	}
}
