using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_ListFusen
{
	public partial class FormExport : Form
	{
		public FormExport()
		{
			InitializeComponent();
		}

		private void FormExport_Load(object sender, EventArgs e)
		{
			// TextBoxにデフォルトでデスクトップパスを表示
			this.textBoxExport.Text = 
				Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		}

		// ボタン：参照
		private void buttonReference_Click(object sender, EventArgs e)
		{
			// FolderBrowserDialogクラスのインスタンスを作成
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			// 上部に表示する説明テキストを指定する
			fbd.Description = "フォルダを指定してください。";
			// ルートフォルダを指定する
			// デフォルトでDesktop
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			// 最初に選択するフォルダを指定する
			// RootFolder以下にあるフォルダである必要がある
			fbd.SelectedPath = @"C:\Windows";
			// ユーザーが新しいフォルダを作成できるようにする
			// デフォルトでTrue
			fbd.ShowNewFolderButton = true;

			// ダイアログを表示する
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				// 選択されたフォルダを表示する
				this.textBoxExport.Text = fbd.SelectedPath;
			}
		}
		// ボタン：出力
		private void buttonOK_Click(object sender, EventArgs e)
		{
			// フォルダパスが有効か判定する
			if (!Directory.Exists(this.textBoxExport.Text))
			{
				MessageBox.Show("出力先のパスが正しいか確認してください");
				return;
			}
			
			// リネーム用TextBoxの文字列を代入
			Form1.expFld = this.textBoxExport.Text;
			// Form1への受渡し用（出力する）
			Form1.expDo = true;
			// FormExportを閉じる
			this.Close();
			
		}
		// ボタン：キャンセル 何もせずダイアログを閉じる
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			// Form1への受渡し用（出力しない）
			Form1.expDo = false;
			// FormExportを閉じる
			this.Close();
		}

		// エスケープキーでダイアログを閉じる
		private void textBoxExport_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				// Form1への受渡し用（出力しない）
				Form1.expDo = false;
				// FormExportを閉じる
				this.Close();
			}
		}
	}
}
