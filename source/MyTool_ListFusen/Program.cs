using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_ListFusen
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			/*
			 * 二重起動を禁止する
			 * https://dobon.net/vb/dotnet/process/checkprevinstance.html
			 */
			//Mutex名を決める（必ずアプリケーション固有の文字列に変更すること！）
			string mutexName = "LisetFusen";
			//Mutexオブジェクトを作成する
			System.Threading.Mutex mutex = new System.Threading.Mutex(false, mutexName);

			bool hasHandle = false;
			try
			{
				try
				{
					//ミューテックスの所有権を要求する
					hasHandle = mutex.WaitOne(0, false);
				}
				//.NET Framework 2.0以降の場合
				catch (System.Threading.AbandonedMutexException)
				{
					//別のアプリケーションがミューテックスを解放しないで終了した時
					hasHandle = true;
				}
				//ミューテックスを得られたか調べる
				if (hasHandle == false)
				{
					//得られなかった場合は、すでに起動していると判断して終了
					MessageBox.Show("多重起動はできません。");
					return;
				}

				//はじめからMainメソッドにあったコードを実行
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			finally
			{
				if (hasHandle)
				{
					//ミューテックスを解放する
					mutex.ReleaseMutex();
				}
				mutex.Close();
			}
		}
	}
}
