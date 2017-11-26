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
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
		}

		// ロード時にチェックボックスやコンボボックスの表示を最新の状態に更新
		private void FormSettings_Load(object sender, EventArgs e)
		{
			checkBoxWordWrap.Checked = Form1.wwrapDo;
			checkBoxAutoSave.Checked = Form1.autoSaveDo;
			checkBoxDeactiveSave.Checked = Form1.deactiveSaveDo;
			comboBoxTick.SelectedIndex = Form1.autoSaveTickId;
		}

		// ボタン：Form1のリストボックスのフォントスタイルを変更
		private void buttonFStyleLB_Click(object sender, EventArgs e)
		{
			try
			{
				// フォント設定ダイアログを表示する
				if (fontDialogLB.ShowDialog() != DialogResult.Cancel)
				{
					// ListBox1のフォントを変える
					Form1.fstyLB = fontDialogLB.Font;
				}
			}
			catch (ArgumentException)
			{
				MessageBox.Show("そのフォントは使えません");
				//throw;
			}
		}
		// ボタン：Form1のリストボックスのフォントカラーを変更
		private void buttonFColorLB_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialogLB.ShowDialog() != DialogResult.Cancel)
			{
				// ListBox1のフォントカラーを変える
				Form1.fcolLB = colorDialogLB.Color;
			}
		}
		// ボタン：Form1のテキストボックスのフォントスタイルを変更
		private void buttonFStyleTB_Click(object sender, EventArgs e)
		{
			try
			{
				// フォント設定ダイアログを表示する
				if (fontDialogTB.ShowDialog() != DialogResult.Cancel)
				{
					// TextBox1のフォントを変える
					Form1.fstyTB = fontDialogTB.Font;
				}
			}
			catch (ArgumentException)
			{
				MessageBox.Show("そのフォントは使えません");
				//throw;
			}
		}
		// ボタン：Form1のテキストボックスのフォントカラーを変更
		private void buttonFColorTB_Click(object sender, EventArgs e)
		{
			// カラー設定ダイアログを表示する
			if (colorDialogTB.ShowDialog() != DialogResult.Cancel)
			{
				// TextBox1のフォントカラーを変える
				Form1.fcolTB = colorDialogTB.Color;
			}
		}

		// ボタン：ListBoxの初期化
		private void buttonResetLB_Click(object sender, EventArgs e)
		{
			Form1.fstyLB = new Font("メイリオ", 10);
			Form1.fcolLB = Color.FromArgb(204, 206, 208);
		}
		// ボタン：TextBoxの初期化
		private void buttonResetTB_Click(object sender, EventArgs e)
		{
			Form1.fstyTB = new Font("メイリオ", 10);
			Form1.fcolTB = Color.FromArgb(204, 206, 208);
		}

		// チェックボックス：右端で折り返す
		private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxWordWrap.Checked)
			{
				Form1.wwrapDo = true; // 右端で折り返す
			}
			else
			{
				Form1.wwrapDo = false; // 右端で折り返さない
			}
		}
		// チェックボックス：オートセーブ
		private void checkBoxAutoSave_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxAutoSave.Checked)
			{
				Form1.autoSaveDo = true;
			}
			else
			{
				Form1.autoSaveDo = false;
			}
		}
		// チェックボックス：非アクティブ時のセーブ
		private void checkBoxDeactiveSave_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxDeactiveSave.Checked)
			{
				Form1.deactiveSaveDo = true;
			}
			else
			{
				Form1.deactiveSaveDo = false;
			}
		}
		// コンボボックス：オートセーブの実行間隔
		private void comboBoxTick_TextChanged(object sender, EventArgs e)
		{
			Form1.autoSaveTickId = comboBoxTick.SelectedIndex;
			Form1.autoSaveTick = int.Parse(comboBoxTick.SelectedItem.ToString()) * 60000;
		}

		// ボタン：OK
		private void buttonOK_Click(object sender, EventArgs e)
		{
			// FormSettingsを閉じる
			this.Close();
		}
	}
}
