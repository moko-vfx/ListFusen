﻿using System;
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
		public static bool addDo = false;                               // アイテムの新規追加を実行するか判定
		public static bool delDo = false;                               // アイテムの削除を実行するか判定
		public static string expFld = "";                               // 一括出力先を保持
		public static bool expDo = false;                               // 一括出力を実行するか判定
		private bool topMost = false;                                   // 最前面表示しているか判定
		private bool dirty = false;										// テキストに変更があったか判定
		public static Font fstyLB;										// ListBoxのフォントの設定
		public static Font fstyTB;                                      // TextBoxのフォントの設定
		public static bool wwrapDo;										// 右端で折り返すか判定
		public static Color fcolLB;										// TextBoxのフォントカラー
		public static Color fcolTB;                                     // ListBoxのフォントカラー
		public static Color pcol1;										// アクセントカラー(メイン)
		public static Color pcol2;                                      // アクセントカラー(サブ)
		private Timer timer;											// オートセーブ用のタイマーの定義
		public static bool autoSaveDo;									// オートセーブするか判定
		public static bool deactiveSaveDo;                              // 非アクティブ時セーブするか判定
		public static int autoSaveTickId;                               // 自動保存の間隔の設定ID
		public static int autoSaveTick;                                 // 自動保存の間隔
		DAndDSizeChanger sizeChanger;									// フォーム枠のサイズ変更用

		// Form1のコンストラクタ
		public Form1()
		{
			InitializeComponent();
		}

		// Form1オブジェクトを保持するためのフィールド
		private static Form1 _form1Instance;
		// Form1オブジェクトを取得、設定するためのプロパティ
		public static Form1 Form1Instance
		{
			get
			{
				return _form1Instance;
			}
			set
			{
				_form1Instance = value;
			}
		}
		// 設定パネルから直接Form1のコントロールの値を変更するためのプロパティ
		public Font listBoxFont
		{
			get
			{
				return listBox1.Font;
			}
			set
			{
				listBox1.Font = value;
			}
		}
		public Color listBoxForeCol
		{
			get
			{
				return listBox1.ForeColor;
			}
			set
			{
				listBox1.ForeColor = value;
			}
		}
		public Font textBoxFont
		{
			get
			{
				return textBox1.Font;
			}
			set
			{
				textBox1.Font = value;
			}
		}
		public Color textBoxForeCol
		{
			get
			{
				return textBox1.ForeColor;
			}
			set
			{
				textBox1.ForeColor = value;
			}
		}
		public Color panelLabel1Col
		{
			get
			{
				return panelLabel1.BackColor;
			}
			set
			{
				panelLabel1.BackColor = value;
			}
		}
		public Color panelLabel2Col
		{
			get
			{
				return panelLabel2.BackColor;
			}
			set
			{
				panelLabel2.BackColor = value;
			}
		}
		public Color panelLabel3Col
		{
			get
			{
				return panelLabel3.BackColor;
			}
			set
			{
				panelLabel3.BackColor = value;
			}
		}
		

		// 起動時にまず実行する内容
		private void Form1_Load(object sender, EventArgs e)
		{
			// 設定パネルから直接Form1のコントロールの値を変更するための準備
			Form1.Form1Instance = this;

			// Form端をドラッグ＆ドロップでサイズ変更可能にする
			sizeChanger = new DAndDSizeChanger(this, this, DAndDArea.All, 8);

			// TextBoxの内容が変化した時のイベントをここでOFFにする
			textBox1.TextChanged -= textBox1_TextChanged;

			// 前回終了時のウインドウ位置とサイズを取得する
			if (Properties.Settings.Default.FormSize.Width == 0 || Properties.Settings.Default.FormSize.Height == 0)
			{
				// 初回起動時にはデザイナーウインドウで指定されている大きさになる

				//既定値に戻す
				Properties.Settings.Default.Reset();
				// フォント周りの変数の初期化
				fstyLB = listBox1.Font;
				fcolLB = listBox1.ForeColor;
				fstyTB = textBox1.Font;
				fcolTB = textBox1.ForeColor;
				// パネルのアクセントカラーの初期化
				pcol1 = panelLabel1.BackColor;
				pcol2 = panelLabel2.BackColor;
				// 右端で折り返す設定を前回終了時の設定に復元
				wwrapDo = Properties.Settings.Default.wwrap;
				// オートセーブ周りの設定を前回終了時の設定に復元
				autoSaveDo = Properties.Settings.Default.autoSave;
				deactiveSaveDo = Properties.Settings.Default.deactiveSave;
				autoSaveTickId = Properties.Settings.Default.autoSaveTId;
				autoSaveTick = Properties.Settings.Default.autoSaveT;
			}
			else
			{
				// 前回終了時のウインドウ位置とサイズに復元
				this.Location = Properties.Settings.Default.FormLocation;
				this.Size = Properties.Settings.Default.FormSize;

				// ListBoxとTextBoxのフォント設定を前回終了時の設定に復元
				this.listBox1.Font = Properties.Settings.Default.listBoxFStyle;
				this.listBox1.ForeColor = Properties.Settings.Default.listBoxFColor;
				this.textBox1.Font = Properties.Settings.Default.textBoxFStyle;
				this.textBox1.ForeColor = Properties.Settings.Default.textBoxFColor;
				// パネルのアクセントカラー設定を前回終了時の設定に復元
				this.panelLabel1.BackColor = Properties.Settings.Default.panelColor1;
				this.panelLabel2.BackColor = Properties.Settings.Default.panelColor2;
				this.panelLabel3.BackColor = Properties.Settings.Default.panelColor1;

				// フォント周りの変数の初期化
				fstyLB = listBox1.Font;
				fcolLB = listBox1.ForeColor;
				fstyTB = textBox1.Font;
				fcolTB = textBox1.ForeColor;
				// パネルのアクセントカラーの初期化
				pcol1 = panelLabel1.BackColor;
				pcol2 = panelLabel2.BackColor;

				// 右端で折り返す設定を前回終了時の設定に復元
				wwrapDo = Properties.Settings.Default.wwrap;
				// SplitContainerの分割する距離を前回終了時の設定に復元
				this.splitContainer1.SplitterDistance = Properties.Settings.Default.splitDist;
				// オートセーブ周りの設定を前回終了時の設定に復元
				autoSaveDo = Properties.Settings.Default.autoSave;
				deactiveSaveDo = Properties.Settings.Default.deactiveSave;
				autoSaveTickId = Properties.Settings.Default.autoSaveTId;
				autoSaveTick = Properties.Settings.Default.autoSaveT;

				if (autoSaveTick == 0)
				{
					//既定値に戻す
					Properties.Settings.Default.Reset();
					// フォント周りの変数の初期化
					fstyLB = listBox1.Font;
					fcolLB = listBox1.ForeColor;
					fstyTB = textBox1.Font;
					fcolTB = textBox1.ForeColor;
					// パネルのアクセントカラーの初期化
					pcol1 = panelLabel1.BackColor;
					pcol2 = panelLabel2.BackColor;
					// 右端で折り返す設定を前回終了時の設定に復元
					wwrapDo = Properties.Settings.Default.wwrap;
					// オートセーブ周りの設定を前回終了時の設定に復元
					autoSaveDo = Properties.Settings.Default.autoSave;
					deactiveSaveDo = Properties.Settings.Default.deactiveSave;
					autoSaveTickId = Properties.Settings.Default.autoSaveTId;
					autoSaveTick = Properties.Settings.Default.autoSaveT;
				}
			}

			// 右端で折り返す設定を反映
			textBox1.WordWrap = wwrapDo;

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
			ShowTextData(); // 選択アイテムの中身をTextBoxに表示

			//カレット位置を末尾に移動
			textBox1.SelectionStart = 0;
			//テキストボックスにフォーカスを移動
			textBox1.Focus();
			//カレット位置までスクロール
			textBox1.ScrollToCaret();

			// ListBoxの選択Indexが変化した時のイベントをここでONにする
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

			// オートセーブ用のタイマーを開始
			timer = new Timer();
			timer.Tick += new EventHandler(doSave);
			timer.Interval = autoSaveTick; // 実行間隔
			timer.Enabled = true; // timer.Start()と同じ
		}

		/*
		 * クラス：メモの情報を保持する
		 */
		public class FusenData
		{
			public string fname = "";	// ListBoxでの表示名を保持
			public string ftext = "";	// ListBoxと連動するテキストデータを保持

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

		// 関数：ListBoxのアイテムを新規追加
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
			// TextBoxの内容が変化した時のイベントをここでOFFにする
			textBox1.TextChanged -= textBox1_TextChanged;

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

			// TextBoxの内容が変化した時のイベントをここでONにする
			textBox1.TextChanged += textBox1_TextChanged;

			// lbSelId更新
			lbSelId = listBox1.SelectedIndex;
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
		public void ListReName()
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
		public void ListDelete()
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

			// ListBoxの選択アイテムの名前を取得
			lbSelName = listBox1.SelectedItem.ToString();
			// ListBoxの選択アイテムのindexを取得
			lbSelId = listBox1.SelectedIndex;

			// リネームダイアログを開く
			FormDelete f = new FormDelete();
			// オーナーウィンドウの真ん中に表示
			f.StartPosition = FormStartPosition.CenterParent;
			// オーナーウィンドウにthisを指定する
			f.ShowDialog(this);
			//フォームが必要なくなったところで、Disposeを呼び出す
			f.Dispose();

			/*
			 * この間、リネームダイアログでの操作
			 */

			// 削除ダイアログを表示
			if (delDo == true)
			{
				// 削除判定のdelDo変数をfalseに戻しておく
				delDo = false;

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
			}

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

			// Dirtyマークを消す
			dirty = false;
			panelDirty.Visible = false;

			showSaved();
		}
		// 「SAVED!」ラベルを1秒間だけ表示
		public async void showSaved()
		{
			this.labelSaved.Visible = true;
			await Task.Run(() => {
				System.Threading.Thread.Sleep(1000);
			});
			this.labelSaved.Visible = false;
		}
		// 関数：オートセーブ用
		public void doSave(object sender, EventArgs e)
		{
			SaveAll();
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
			ListReName();
		}
		// イベント：ListBoxダブルクリックでリネーム
		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListReName();
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
			ListDelete();
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

		// ボタン：Settings マウスオーバーで画像差し替え
		private void buttonSettings_MouseEnter(object sender, EventArgs e)
		{
			buttonSettings.BackgroundImage = Properties.Resources.on_settings;
		}
		private void buttonSettings_MouseLeave(object sender, EventArgs e)
		{
			buttonSettings.BackgroundImage = Properties.Resources.settings;
		}
		// ボタン：Settings
		private void buttonSettings_MouseClick(object sender, MouseEventArgs e)
		{
			// ツール設定ダイアログを開く
			FormSettings f = new FormSettings();
			// オーナーウィンドウの真ん中に表示
			f.StartPosition = FormStartPosition.CenterParent;
			// オーナーウィンドウにthisを指定する
			f.ShowDialog(this);
			//フォームが必要なくなったところで、Disposeを呼び出す
			f.Dispose();

			/*
			 * この間、ツール設定ダイアログでの操作
			 */
			
			// フォントの設定を更新
			listBox1.Font = fstyLB;
			listBox1.ForeColor = fcolLB;
			textBox1.Font = fstyTB;
			textBox1.ForeColor = fcolTB;

			// パネルのカラーを更新
			panelLabel1.BackColor = pcol1;
			panelLabel2.BackColor = pcol2;
			panelLabel3.BackColor = pcol1;

			// 右端で折り返す設定を更新
			if (wwrapDo == true)
			{
				textBox1.WordWrap = true; // 折り返す
			}
			else
			{
				textBox1.WordWrap = false; // 折り返さない
			}

			// オートセーブの設定を更新
			if (autoSaveDo == true)
			{
				timer.Interval = autoSaveTick; // 実行間隔
				timer.Enabled = true; // timer.Start()と同じ
			}
			else
			{
				timer.Enabled = false; // timer.Stop()と同じ
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
		// イベント：Form非アクティブ時にSave
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			// 非アクティブ時にセーブするオプション設定がONの場合のみ実行
			if (deactiveSaveDo == true)
			{
				SaveAll();
			}
		}
		// イベント：テキストに変更があればDirtyマークを付ける
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			dirty = true;
			panelDirty.Visible = true;
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
		// 終了時にウインドウ位置とサイズ・各種設定を記憶して次回反映させる
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// ウインドウステートがNormal前提で、位置（location）とサイズ（size）を記憶する。
			Properties.Settings.Default.FormLocation = this.Location;
			Properties.Settings.Default.FormSize = this.Size;
			// フォントの設定を記憶する
			Properties.Settings.Default.listBoxFStyle = this.listBox1.Font;
			Properties.Settings.Default.listBoxFColor = this.listBox1.ForeColor;
			Properties.Settings.Default.textBoxFStyle = this.textBox1.Font;
			Properties.Settings.Default.textBoxFColor = this.textBox1.ForeColor;
			// アクセントカラーの設定を記憶する
			Properties.Settings.Default.panelColor1 = this.panelLabel1.BackColor;
			Properties.Settings.Default.panelColor2 = this.panelLabel2.BackColor;
			// 右端で折り返す設定を記憶する
			Properties.Settings.Default.wwrap = wwrapDo;
			// 分割の距離を保存する
			Properties.Settings.Default.splitDist = this.splitContainer1.SplitterDistance;
			// オートセーブ関連の設定を保存する
			Properties.Settings.Default.autoSave = autoSaveDo;
			Properties.Settings.Default.deactiveSave = deactiveSaveDo;
			Properties.Settings.Default.autoSaveTId = autoSaveTickId;
			Properties.Settings.Default.autoSaveT = autoSaveTick;

			// ここで設定を保存する
			Properties.Settings.Default.Save();
		}

		// ListBoxのショートカットキー設定
		private void listBox1_KeyDown(object sender, KeyEventArgs e)
		{
			// 保存
			if (e.Control && e.KeyCode == Keys.S)
			{
				SaveAll();
				e.SuppressKeyPress = true;
			}
			// リストアイテムのリネーム
			if (e.KeyData == Keys.F2)
			{
				ListReName();
				e.SuppressKeyPress = true;
			}
			// リストアイテムの削除
			if (e.KeyData == Keys.Delete)
			{
				ListDelete();
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
			// リストアイテムのリネーム
			if (e.KeyData == Keys.F2)
			{
				ListReName();
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

		/// <summary>
		/// コントロールの端をD＆Dすることによってサイズを変更出来る機能を提供するクラス
		/// こちらの記事のコードを利用させていただいています
		/// http://anis774.net/codevault/danddsizechanger.html
		/// </summary>
		class DAndDSizeChanger
		{
			Control mouseListner;
			Control sizeChangeCtrl;
			DAndDArea sizeChangeArea;
			Size lastMouseDownSize;
			Point lastMouseDownPoint;
			DAndDArea status;
			int sizeChangeAreaWidth;
			Cursor defaultCursor;

			/// <param name="mouseListner">マウス入力を受け取るコントロール</param>
			/// <param name="sizeChangeCtrl">マウス入力によってサイズが変更されるコントロール</param>
			/// <param name="sizeChangeArea">上下左右のサイズ変更が有効になる範囲を指定</param>
			/// <param name="sizeChangeAreaWidth">サイズ変更が有効になる範囲の幅を指定</param>
			public DAndDSizeChanger(Control mouseListner, Control sizeChangeCtrl, DAndDArea sizeChangeArea, int sizeChangeAreaWidth)
			{
				this.mouseListner = mouseListner;
				this.sizeChangeCtrl = sizeChangeCtrl;
				this.sizeChangeAreaWidth = sizeChangeAreaWidth;
				this.sizeChangeArea = sizeChangeArea;
				defaultCursor = mouseListner.Cursor;

				mouseListner.MouseDown += new MouseEventHandler(mouseListner_MouseDown);
				mouseListner.MouseMove += new MouseEventHandler(mouseListner_MouseMove);
				mouseListner.MouseUp += new MouseEventHandler(mouseListner_MouseUp);
				// マウスカーソルが通常に戻らない現象回避のために追加
				mouseListner.MouseLeave += new EventHandler(MouseListner_MouseLeave);
			}

			// 関数：マウスカーソルが通常に戻らない現象回避のために追加
			private void MouseListner_MouseLeave(object sender, EventArgs e)
			{
				mouseListner.Cursor = defaultCursor;
			}

			void mouseListner_MouseDown(object sender, MouseEventArgs e)
			{
				lastMouseDownPoint = e.Location;
				lastMouseDownSize = sizeChangeCtrl.Size;

				//動作を決定
				status = DAndDArea.None;
				if (getTop().Contains(e.Location))
				{
					status |= DAndDArea.Top;
				}
				if (getLeft().Contains(e.Location))
				{
					status |= DAndDArea.Left;
				}
				if (getBottom().Contains(e.Location))
				{
					status |= DAndDArea.Bottom;
				}
				if (getRight().Contains(e.Location))
				{
					status |= DAndDArea.Right;
				}

				if (status != DAndDArea.None)
				{
					mouseListner.Capture = true;
				}
			}

			void mouseListner_MouseMove(object sender, MouseEventArgs e)
			{
				//カーソルを変更
				if ((getTop().Contains(e.Location) &&
					getLeft().Contains(e.Location)) ||
					(getBottom().Contains(e.Location) &&
					getRight().Contains(e.Location)))
				{

					mouseListner.Cursor = Cursors.SizeNWSE;
				}
				else if ((getTop().Contains(e.Location) &&
				  getRight().Contains(e.Location)) ||
				  (getBottom().Contains(e.Location) &&
				  getLeft().Contains(e.Location)))
				{

					mouseListner.Cursor = Cursors.SizeNESW;
				}
				else if (getTop().Contains(e.Location) ||
				  getBottom().Contains(e.Location))
				{

					mouseListner.Cursor = Cursors.SizeNS;
				}
				else if (getLeft().Contains(e.Location) ||
				  getRight().Contains(e.Location))
				{

					mouseListner.Cursor = Cursors.SizeWE;
				}
				else
				{
					mouseListner.Cursor = defaultCursor;
				}

				if (e.Button == MouseButtons.Left)
				{
					int diffX = e.X - lastMouseDownPoint.X;
					int diffY = e.Y - lastMouseDownPoint.Y;

					if ((status & DAndDArea.Top) == DAndDArea.Top)
					{
						int h = sizeChangeCtrl.Height;
						sizeChangeCtrl.Height -= diffY;
						sizeChangeCtrl.Top += h - sizeChangeCtrl.Height;
					}
					if ((status & DAndDArea.Bottom) == DAndDArea.Bottom)
					{
						sizeChangeCtrl.Height = lastMouseDownSize.Height + diffY;
					}
					if ((status & DAndDArea.Left) == DAndDArea.Left)
					{
						int w = sizeChangeCtrl.Width;
						sizeChangeCtrl.Width -= diffX;
						sizeChangeCtrl.Left += w - sizeChangeCtrl.Width;
					}
					if ((status & DAndDArea.Right) == DAndDArea.Right)
					{
						sizeChangeCtrl.Width = lastMouseDownSize.Width + diffX;
					}
				}
			}

			void mouseListner_MouseUp(object sender, MouseEventArgs e)
			{
				mouseListner.Capture = false;
			}

			/// <summary>
			/// ポイントがD＆Dするとサイズが変更されるエリア内にあるかどうかを判定します。
			/// </summary>
			public bool ContainsSizeChangeArea(Point p)
			{
				return getTop().Contains(p) ||
					getBottom().Contains(p) ||
					getLeft().Contains(p) ||
					getRight().Contains(p);
			}

			private Rectangle getTop()
			{
				if ((sizeChangeArea & DAndDArea.Top) == DAndDArea.Top)
				{
					return new Rectangle(0, 0, mouseListner.Width, sizeChangeAreaWidth);
				}
				else
				{
					return new Rectangle();
				}
			}

			private Rectangle getBottom()
			{
				if ((sizeChangeArea & DAndDArea.Bottom) == DAndDArea.Bottom)
				{
					return new Rectangle(0, mouseListner.Height - sizeChangeAreaWidth,
						mouseListner.Width, sizeChangeAreaWidth);
				}
				else
				{
					return new Rectangle();
				}
			}

			private Rectangle getLeft()
			{
				if ((sizeChangeArea & DAndDArea.Left) == DAndDArea.Left)
				{
					return new Rectangle(0, 0,
						sizeChangeAreaWidth, mouseListner.Height);
				}
				else
				{
					return new Rectangle();
				}
			}

			private Rectangle getRight()
			{
				if ((sizeChangeArea & DAndDArea.Right) == DAndDArea.Right)
				{
					return new Rectangle(mouseListner.Width - sizeChangeAreaWidth, 0,
						sizeChangeAreaWidth, mouseListner.Height);
				}
				else
				{
					return new Rectangle();
				}
			}
		}

		public enum DAndDArea
		{
			None = 0,
			Top = 1,
			Bottom = 2,
			Left = 4,
			Right = 8,
			All = 15
		}
	}
}
