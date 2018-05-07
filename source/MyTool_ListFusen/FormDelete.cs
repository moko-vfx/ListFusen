using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_ListFusen
{
	public partial class FormDelete : Form
	{
		public FormDelete()
		{
			InitializeComponent();
		}

		// 変数を定義
		string selName = "";

		private void FormDelete_Load(object sender, EventArgs e)
		{
			// 選択中のリスト名を取得
			selName = Form1.lbSelName; // staticにしたので取得できる
									   // リネーム用TextBoxに表示
			this.labelSelItem.Text = "\" " + selName + " \"";

			// 上部のパネルの色を更新
			panel1.BackColor = Form1.pcol1;
		}

		// ボタン：OK ListBoxに新しい名前を反映
		private void buttonOK_Click(object sender, EventArgs e)
		{
			// Form1への受渡し用（削除する）
			Form1.delDo = true;
			// FormReNameを閉じる
			this.Close();
		}
		// ボタン：キャンセル 何もせずダイアログを閉じる
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			// Form1への受渡し用（削除しない）
			Form1.delDo = false;
			// FormReNameを閉じる
			this.Close();
		}

		// エスケープキーでダイアログを閉じる
		private void buttonOK_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
		private void buttonCancel_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
