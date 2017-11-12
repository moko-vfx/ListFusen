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
	public partial class Form1 : Form
	{
		// 定数の定義
		public const string TEXTFLD = "data";						// テキストファイルの保存先フォルダ名
		public const string LISTDATA = TEXTFLD + @"/_listbox.txt";	// リストボックスを保存するtxt名
		public const string NEWTITLE = "新規メモ";					// 新規テキストファイルの中身

        // 変数の定義
        private int mouseX; // マウスX座標
		private int mouseY; // マウスY座標
        private Encoding ENCODE = Encoding.GetEncoding("shift_jis");	// 文字コード指定
        private List<String> listAllName = new List<string>();			// ListBoxの全アイテム名を保持
		private List<String> listAllText = new List<string>();			// ListBoxの全テキスト名を保持
		private int lbSelId = 0;										// ListBoxで選択中のIndexを保持
		public static string lbSelName = "";                            // ListBoxで選択中のアイテムを保持
		public static bool addDo = false;								// リストの新規追加をするか判定
		public static string expFld = "";                               // 一括出力先を保持
		public static bool expDo = false;                               // 一括出力先するか判定
		private bool topMost = false;									// 最前面表示しているかを判定

		// Form1のコンストラクタ
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 前回終了時のウインドウ位置とサイズを取得する
			if (Properties.Settings.Default.FormSize.Width == 0 || Properties.Settings.Default.FormSize.Height == 0)
			{
				// 初回起動時にはデザイナーウインドウで指定されている大きさになる
			}
			else
			{
				this.Location = Properties.Settings.Default.FormLocation;
				this.Size = Properties.Settings.Default.FormSize;
			}

			// テキストファイルの保存フォルダがある場合
			if (Directory.Exists(TEXTFLD))
			{
				// ListBoxのアイテム名を保存したファイルがある場合
				if (File.Exists(LISTDATA))
				{
					// アイテム名を保持したテキストファイルを読み込む
					StreamReader sr1 = new StreamReader(
						LISTDATA,
                        ENCODE);
                    // 1行ずつListに格納
                    string line = "";
					while ((line = sr1.ReadLine()) != null)
					{
						listAllName.Add(line);
					}
                    sr1.Close();

					// TextBoxに表示するテキストファイルをListに読み込む
					for (int i = 0; i < listAllName.Count; i++)
					{
						StreamReader sr2 = new StreamReader(
							TEXTFLD + @"/" + i.ToString() + @".txt",
							ENCODE);
						listAllText.Add(sr2.ReadToEnd());
						sr2.Close();
					}

					// 読み込んだ内容をListBoxに追加
					for (int i = 0; i < listAllName.Count; i++)
					{
						string ln = listAllName[i];
						string td = listAllText[i];
						// 付箋クラスのオブジェクトを生成
						FusenData fdata = new FusenData(ln, td);
						listBox1.Items.Add(fdata);
					}
				}
				// ListBoxの項目を保存したファイルが無い場合
				else
				{
					// ファイルを作成する
					var sw = new StreamWriter(
						LISTDATA,
						false,
                        ENCODE);
					sw.WriteLine(NEWTITLE);
					sw.Close();

					// ListBoxの新規アイテムを追加
					ListAdd();
				}
			}
			// テキストファイルの保存フォルダが無い場合
			else
			{
				// フォルダを作成する
				DirectoryInfo di = Directory.CreateDirectory(TEXTFLD);

				// ファイルを作成する
				var sw = new StreamWriter(
					LISTDATA,
					false,
                    ENCODE);
				sw.WriteLine(NEWTITLE);
				sw.Close();

				// ListBoxの新規アイテムを追加
				ListAdd();
			}

			SelTop();		// 先頭のアイテムを選択
			ShowTextData();	// 選択アイテムの中身をTextBoxに表示

			// ListBoxの選択Indexが変化した時のイベントをここでONにする
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

		/*
		 * クラス：メモの情報を保持する
		 */
		public class FusenData
		{
			public string fname = "";		// ListBoxでの表示名を保持
			public string ftext = "";    // ListBoxと連動するテキストデータを保持

			// コンストラクタで情報を代入
			public FusenData(string ln, string td)
			{
				fname = ln;
				ftext = td;
			}
			// エラー対策
			public override string ToString()
			{
				return fname;
			}
		}

		// ListBoxのアイテムを新規追加
		private void ListAdd()
		{
			// ListBoxのアイテム数を調べる( = 新規追加するindex)
			int i = listBox1.Items.Count;

			// n.txtファイルを作成する
			var sw = new StreamWriter(
				TEXTFLD + @"/" + i.ToString() + @".txt",
				false,
                ENCODE);
			sw.Close();

			// ListBoxの選択アイテムの名前を取得
			lbSelName = NEWTITLE;

			// リネームダイアログを開く
			FormReName f = new FormReName();
			// オーナーウィンドウの真ん中に表示
			f.StartPosition = FormStartPosition.CenterParent;
			// オーナーウィンドウにthisを指定する
			f.ShowDialog(this);
			//フォームが必要なくなったところで、Disposeを呼び出す
			f.Dispose();

			/*
			 * この間、リネームダイアログでの操作
			 */

			// ダイアログで"OK"したかを判定
			if (addDo == true)
			{
				// 付箋オブジェクトを指定した名前で生成
				FusenData fdata = new FusenData(
					lbSelName,
					null);
				listBox1.Items.Add(fdata);
			}
		}
		
		// イベント：ListBoxのアイテムの選択先を変えた時
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			MemoryTextData();
			ShowTextData();
		}

		// 関数：Texboxの内容を記憶する
		public void MemoryTextData()
		{
			// 選択アイテムの付箋データにアクセスして代入
			FusenData fdata = (FusenData)listBox1.Items[lbSelId];
			fdata.ftext = textBox1.Text;
		}

		// 関数：ListBoxの選択アイテムの内容をTextBoxに表示
		public void ShowTextData()
		{
			// 選択アイテムの付箋データにアクセスして表示
			FusenData fdata = (FusenData)listBox1.Items[listBox1.SelectedIndex];
			textBox1.Text = fdata.ftext;
			// lbSelId更新
			lbSelId = listBox1.SelectedIndex;

			//カレット位置を末尾に移動
			textBox1.SelectionStart = 0;
			//テキストボックスにフォーカスを移動
			textBox1.Focus();
			//カレット位置までスクロール
			textBox1.ScrollToCaret();
		}

		// 関数：ListBox先頭のアイテムを選択
		public void SelTop()
		{
			listBox1.SetSelected(0, true);
			lbSelId = 0; // lbSelId更新
		}

		// 関数：ListBoxの選択アイテムを1つ上に移動
		public void ListMoveUp()
		{
			// アイテムを何も選択していない場合はメッセージを表示
			if (listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("リストを選択してください");
				return;
			}

			// 選択しているListBoxのIndexが0以下なら何もしない
			if (listBox1.SelectedIndex <= 0)
			{
				return;
			}

			// ListBoxの選択Indexが変化した時のイベントをここでOFFにする
			listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

			MemoryTextData();

			// 選択アイテムのIndexを記憶
			lbSelId = listBox1.SelectedIndex;
			// 選択アイテムの1つ上のアイテムを記憶
			var fdata = listBox1.Items[lbSelId - 1] as FusenData;
			// 選択アイテムの1つ上のアイテムを削除
			listBox1.Items.RemoveAt(lbSelId - 1);
			// 選択アイテムだった位置に1つの上のアイテムを挿入（これで入れ替わる）
			listBox1.Items.Insert(lbSelId, fdata);

			// ListBoxの選択Indexが変化した時のイベントをここでONにする
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

			// lbSelId更新
			lbSelId = lbSelId - 1;
			// 更新したlbSelIdを選択
			listBox1.SetSelected(lbSelId, true);
		}

		// 関数：ListBoxの選択アイテムを1つ下に移動
		public void ListMoveDown()
		{
			// アイテムを何も選択していない場合はメッセージを表示
			if (listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("リストを選択してください");
				return;
			}

			// 選択しているListBoxのIndexが最後なら何もしない
			if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
			{
				return;
			}

			// ListBoxの選択Indexが変化した時のイベントをここでOFFにする
			listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

			MemoryTextData();

			// 選択アイテムのIndexを記憶
			lbSelId = listBox1.SelectedIndex;
			// 選択アイテムの1つ下のアイテムを記憶
			var fdata = listBox1.Items[lbSelId + 1] as FusenData;
			// 選択アイテムの1つ下のアイテムを削除
			listBox1.Items.RemoveAt(lbSelId + 1);
			// 選択アイテムだった位置に1つの上のアイテムを挿入（これで入れ替わる）
			listBox1.Items.Insert(lbSelId, fdata);

			// ListBoxの選択Indexが変化した時のイベントをここでONにする
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

			// lbSelId更新
			lbSelId = lbSelId + 1;
			// 更新したlbSelIdを選択
			listBox1.SetSelected(lbSelId, true);
		}

		// 関数：ListBoxの選択アイテムのリネーム
		public void ListMoveReName()
		{
			// アイテムを何も選択していない場合はメッセージを表示
			if (listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("リストを選択してください");
				return;
			}

			// ListBoxの選択Indexが変化した時のイベントをここでOFFにする
			listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

			// ListBoxの選択アイテムの名前を取得
			lbSelName = listBox1.SelectedItem.ToString();
			// ListBoxの選択アイテムのindexを取得
			lbSelId = listBox1.SelectedIndex;

			// リネームダイアログを開く
			FormReName f = new FormReName();
			// オーナーウィンドウの真ん中に表示
			f.StartPosition = FormStartPosition.CenterParent;
			// オーナーウィンドウにthisを指定する
			f.ShowDialog(this);
			//フォームが必要なくなったところで、Disposeを呼び出す
			f.Dispose();

			/*
			 * この間、リネームダイアログでの操作
			 */

			// 付箋インスタンスに新しい名前を与えてListBoxに反映させる
			FusenData fdata = (FusenData)listBox1.Items[lbSelId];
			fdata.fname = lbSelName;
			listBox1.Items[lbSelId] = fdata;

			// ListBoxの選択Indexが変化した時のイベントをここでONにする
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
		}

		// 関数：ListBoxの選択アイテムを削除
		public void ListMoveDelete()
		{
			// アイテムを何も選択していない場合はメッセージを表示
			if (listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("リストを選択してください");
				return;
			}

			// ListBoxのアイテムが1つ以下の場合はreturn
			if (listBox1.Items.Count <= 1)
			{
				MessageBox.Show("これ以上リストは消せません");
				return;
			}

			// ListBoxの選択Indexが変化した時のイベントをここでOFFにする
			listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

			// ListBoxの選択アイテムを削除
			listBox1.Items.RemoveAt(listBox1.SelectedIndex);

			// 最後のアイテムを削除した場合はlbSelIdを更新
			if (lbSelId == listBox1.Items.Count)
			{
				listBox1.SetSelected(listBox1.Items.Count - 1, true);
			}
			else
			{
				listBox1.SetSelected(lbSelId, true);
			}
			// liseSelIdを更新
			lbSelId = listBox1.SelectedIndex;

			ShowTextData();

			// ListBoxの選択Indexが変化した時のイベントをここでONにする
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
		}

		// 関数：全ての内容を保存する
		public void SaveAll()
		{
			// 現在開いているTextBoxの内容を記憶
			MemoryTextData();

			// 現在のListBoxの内容を1項目ずつ改行して代入
			string s = "";
			foreach (Object obj in listBox1.Items)
			{
				s += obj.ToString() + Environment.NewLine;
			}
			// 内容を項目保存用テキストに書き込み
			File.WriteAllText(
				LISTDATA,
				s,
                ENCODE);

			// 全ての付箋オブジェクトのテキスト内容をテキストファイルに保存
			for (int i = 0; i < listBox1.Items.Count; i++)
			{
				FusenData fdata = (FusenData)listBox1.Items[i];
				File.WriteAllText(
					TEXTFLD + @"/" + i.ToString() + @".txt",
					fdata.ftext,
                    ENCODE);
			}

			showSaved();
		}
		// 「SAVED!」ラベルを1秒間だけ表示
		public async void showSaved()
		{
			this.labelSaved.Visible = true;
			await Task.Run(() => {
				System.Threading.Thread.Sleep(1000);  // 重たい処理のつもり
			});
			this.labelSaved.Visible = false;
		}

		// 関数：全ての内容を一括出力する
		public void ExportAll()
		{
			// 現在開いているTextBoxの内容を記憶
			MemoryTextData();

			// 一括出力ダイアログを開く
			FormExport f = new FormExport();
			// オーナーウィンドウの真ん中に表示
			f.StartPosition = FormStartPosition.CenterParent;
			// オーナーウィンドウにthisを指定する
			f.ShowDialog(this);
			//フォームが必要なくなったところで、Disposeを呼び出す
			f.Dispose();

			/*
			 * この間、リネームダイアログでの操作
			 */
			
			// 一括出力"する"判定の場合のみ実行
			if (expDo == true)
			{
				//ファイル名に使用できない文字があるかチェック
				char[] invalidChars = Path.GetInvalidFileNameChars();

				for (int i = 0; i < listBox1.Items.Count; i++)
				{
					string fileName = listBox1.Items[i].ToString();
					if (fileName.IndexOfAny(invalidChars) >= 0)
					{
						MessageBox.Show("リスト内にファイル名に使用できない文字が使われています: " + fileName);
						return;
					}
				}

				// 全ての付箋オブジェクトのテキスト内容をテキストファイルに保存
				try
				{
					for (int i = 0; i < listBox1.Items.Count; i++)
					{
						FusenData fdata = (FusenData)listBox1.Items[i];

						// 2つのパスを結合する(フォルダパス末尾に"\"がある場合と無い場合に対処できる)
						string mergePath = Path.Combine(expFld, listBox1.Items[i].ToString() + @".txt");

						File.WriteAllText(
							mergePath,
							fdata.ftext,
							ENCODE);
					}
				}
				catch (Exception)
				{
					MessageBox.Show("リスト名がファイル名に使用できない可能性があります");
					MessageBox.Show("出力を中断します");
					return;
				}

				MessageBox.Show("出力が完了しました");
			}
		}

		// ボタン：Up マウスオーバーで画像差し替え
		private void buttonUp_MouseEnter(object sender, EventArgs e)
		{
			buttonUp.BackgroundImage = Properties.Resources.on_up;
		}
		private void buttonUp_MouseLeave(object sender, EventArgs e)
		{
			buttonUp.BackgroundImage = Properties.Resources.up;
		}
		// ボタン：Up
		private void buttonUp_MouseClick(object sender, MouseEventArgs e)
		{
			ListMoveUp();
		}

		// ボタン：Down マウスオーバーで画像差し替え
		private void buttonDown_MouseEnter(object sender, EventArgs e)
		{
			buttonDown.BackgroundImage = Properties.Resources.on_down;
		}
		private void buttonDown_MouseLeave(object sender, EventArgs e)
		{
			buttonDown.BackgroundImage = Properties.Resources.down;
		}
		// ボタン：Down
		private void buttonDown_MouseClick(object sender, MouseEventArgs e)
		{
			ListMoveDown();
		}

		// ボタン：Add マウスオーバーで画像差し替え
		private void buttonAdd_MouseEnter(object sender, EventArgs e)
		{
			buttonAdd.BackgroundImage = Properties.Resources.on_add;
		}
		private void buttonAdd_MouseLeave(object sender, EventArgs e)
		{
			buttonAdd.BackgroundImage = Properties.Resources.add;
		}
		// ボタン：Add
		private void buttonAdd_MouseClick(object sender, MouseEventArgs e)
		{
			ListAdd();
		}

		// ボタン：ReName マウスオーバーで画像差し替え
		private void buttonReName_MouseEnter(object sender, EventArgs e)
		{
			buttonReName.BackgroundImage = Properties.Resources.on_pen;
		}
		private void buttonReName_MouseLeave(object sender, EventArgs e)
		{
			buttonReName.BackgroundImage = Properties.Resources.pen;
		}
		// ボタン：ReName
		private void buttonReName_MouseClick(object sender, MouseEventArgs e)
		{
			ListMoveReName();
		}

		// ボタン：Del マウスオーバーで画像差し替え
		private void buttonDel_MouseEnter(object sender, EventArgs e)
		{
			buttonDel.BackgroundImage = Properties.Resources.on_del;
		}
		private void buttonDel_MouseLeave(object sender, EventArgs e)
		{
			buttonDel.BackgroundImage = Properties.Resources.del;
		}
		// ボタン：Del
		private void buttonDel_MouseClick(object sender, MouseEventArgs e)
		{
			ListMoveDelete();
		}

		// ボタン：Undo マウスオーバーで画像差し替え
		private void buttonUndo_MouseEnter(object sender, EventArgs e)
		{
			// Undoできるか?
			if (textBox1.CanUndo == true)
			{
				buttonUndo.BackgroundImage = Properties.Resources.on_undo;
			}
		}
		private void buttonUndo_MouseLeave(object sender, EventArgs e)
		{
			buttonUndo.BackgroundImage = Properties.Resources.undo;
		}
		// ボタン：Undo
		private void buttonUndo_MouseClick(object sender, MouseEventArgs e)
		{
			// Undoできるか?
			if (textBox1.CanUndo == true)
			{
				// Undoを実行する
				textBox1.Undo();
			}
		}

		// ボタン：Redo マウスオーバーで画像差し替え ※リッチテキストボックス対応時用
		private void buttonRedo_MouseEnter(object sender, EventArgs e)
		{
			// Undoできるか?
			if (textBox1.CanUndo == true)
			{
				buttonRedo.BackgroundImage = Properties.Resources.on_redo;
			}
		}
		private void buttonRedo_MouseLeave(object sender, EventArgs e)
		{
			buttonRedo.BackgroundImage = Properties.Resources.redo;
		}
		// ボタン：Redo ※リッチテキストボックス対応時用(現状では中身はUndo)
		private void buttonRedo_MouseClick(object sender, MouseEventArgs e)
		{
			// Undoできるか?
			if (textBox1.CanUndo == true)
			{
				// Undoを実行する
				textBox1.Undo();
			}
		}

		// ボタン：Export マウスオーバーで画像差し替え
		private void buttonExport_MouseEnter(object sender, EventArgs e)
		{
			buttonExport.BackgroundImage = Properties.Resources.on_export;
		}
		private void buttonExport_MouseLeave(object sender, EventArgs e)
		{
			buttonExport.BackgroundImage = Properties.Resources.export;
		}
		// ボタン：Export
		private void buttonExport_MouseClick(object sender, MouseEventArgs e)
		{
			ExportAll();
		}

		// ボタン：Save マウスオーバーで画像差し替え
		private void buttonSave_MouseEnter(object sender, EventArgs e)
		{
			buttonSave.BackgroundImage = Properties.Resources.on_save;
		}
		private void buttonSave_MouseLeave(object sender, EventArgs e)
		{
			buttonSave.BackgroundImage = Properties.Resources.save;
		}
		// ボタン：Save
		private void buttonSave_MouseClick(object sender, MouseEventArgs e)
		{
			SaveAll();
		}
		
		// ボタン：最前面表示 ON / OFF のトグル
		private void buttonFront_MouseClick(object sender, MouseEventArgs e)
		{
			if (topMost == false)
			{
				buttonFront.BackgroundImage = Properties.Resources.on_front;
				this.TopMost = true;
				topMost = true;
			}
			else
			{
				buttonFront.BackgroundImage = Properties.Resources.front;
				this.TopMost = false;
				topMost = false;
			}
		}

		// ボタン：アプリケーション終了
		private void labelEsc_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		// 終了時にウインドウ位置とサイズを記憶して次回反映させる
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// ウインドウステートがNormal前提で、位置（location）とサイズ（size）を記憶する。
			Properties.Settings.Default.FormLocation = this.Location;
			Properties.Settings.Default.FormSize = this.Size;

			// ここで設定を保存する
			Properties.Settings.Default.Save();
		}

		// ListBoxのショートカットキー設定
		private void listBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveAll();
				e.SuppressKeyPress = true;
			}
		}
		// TextBoxのショートカットキー設定
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			// 保存
			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveAll();
				e.SuppressKeyPress = true;
			}
			// テキスト全選択
			if (e.Control && e.KeyCode == Keys.A)
			{
				textBox1.SelectAll();
				e.SuppressKeyPress = true;
			}
		}

		// ツールのドラッグ＆ドロップ移動の対応
		private void panelButton_MouseDown(object sender, MouseEventArgs e)
		{
			// 判定 押されたボタンはマウスの左ボタン？
			if (e.Button == MouseButtons.Left)
			{
				// Yesの場合
				this.mouseX = e.X;  // マウスX座標を記憶
				this.mouseY = e.Y;  // マウスY座標を記憶
			}
		}
		private void panelButton_MouseMove(object sender, MouseEventArgs e)
		{
			// 判定:押されたボタンはマウスの左ボタン？
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - mouseX;  // フォームのX座標を更新
				this.Top += e.Y - mouseY;   // フォームのY座標を更新
			}
		}
		private void panelUP_MouseDown(object sender, MouseEventArgs e)
		{
			// 判定 押されたボタンはマウスの左ボタン？
			if (e.Button == MouseButtons.Left)
			{
				// Yesの場合
				this.mouseX = e.X;  // マウスX座標を記憶
				this.mouseY = e.Y;  // マウスY座標を記憶
			}
		}
		private void panelUP_MouseMove(object sender, MouseEventArgs e)
		{
			// 判定:押されたボタンはマウスの左ボタン？
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - mouseX;  // フォームのX座標を更新
				this.Top += e.Y - mouseY;   // フォームのY座標を更新
			}
		}

		/*
		// ListBoxの背景色を変える
		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index < 0) return; //無駄な描画をさせないよう抜ける

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e = new DrawItemEventArgs(e.Graphics,
				e.Font,
				e.Bounds,
				e.Index,
				e.State ^ DrawItemState.Selected,
				e.ForeColor,
				Color.Goldenrod); // 最後の引数が背景色
			}
			e.DrawBackground();
			e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
			e.DrawFocusRectangle();
		}
		*/


		// 残っている実装：
		//
		// ・ListBoxとListBox選択時の背景色を水色ではなく任意の色にしたい（優先度：高）
		//
		// ・スクロールバーの色や幅を変えたい（優先度：低）
		// ・ツールの位置とサイズをできればroamingの所ではなくテキストデータで保持する（優先度：低）
		// ・文字サイズやカラーリングを変えるオプションを付ける（優先度：低）
		// ・TextBoxのカーソル位置を記憶させる（付箋クラスに変数を増設でいけそう）
		//
		// ・変更があったら終了時にダイアログボックスを表示する（優先度：低）
		// 　※TextChangeイベントでBlool変数をTrueにして1つでもtrueがあれば表示させるのでいけそう？
	}
}
