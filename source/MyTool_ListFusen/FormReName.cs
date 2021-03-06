﻿using System;
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
	public partial class FormReName : Form
	{
		public FormReName()
		{
			InitializeComponent();
		}

		// 変数を定義
		string newName = "";

		private void FormReName_Load(object sender, EventArgs e)
		{
			// 選択中のリスト名を取得
			newName = Form1.lbSelName; // staticにしたので取得できる
			// リネーム用TextBoxに表示
			this.textBoxReName.Text = newName;

			// 上部のパネルの色を更新
			panel1.BackColor = Form1.pcol1;
		}

		// ボタン：OK ListBoxに新しい名前を反映
		private void buttonOK_Click(object sender, EventArgs e)
		{
			// リネーム用TextBoxの文字列を代入
			Form1.lbSelName = this.textBoxReName.Text;
			// Form1への受渡し用（リネームする）
			Form1.addDo = true;
			// FormReNameを閉じる
			this.Close();
		}
		// ボタン：キャンセル 何もせずダイアログを閉じる
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			// Form1への受渡し用（リネームしない）
			Form1.addDo = false;
			// FormReNameを閉じる
			this.Close();
		}

		// テキストボックス内のショートカットキー
		private void textBoxReName_KeyDown(object sender, KeyEventArgs e)
		{
			// エンターキーで決定
			if (e.KeyCode == Keys.Enter)
			{
				// リネーム用TextBoxの文字列を代入
				Form1.lbSelName = this.textBoxReName.Text;
				// Form1への受渡し用（リネームする）
				Form1.addDo = true;
				// FormReNameを閉じる
				this.Close();
			}

			// エスケープキーでダイアログを閉じる
			if (e.KeyCode == Keys.Escape)
			{
				// Form1への受渡し用（リネームしない）
				Form1.addDo = false;
				this.Close();
			}
		}
	}
}
