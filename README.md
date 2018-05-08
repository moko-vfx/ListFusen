# ListFusen
付箋紙ツールのようなお手軽さとリスト管理を合わせたテキストエディタ  
　  
**◆『List Fusen』について**  
　  
　使用時は ListFusen_v102.exe を実行してください。  
　  
　主な使用方法につきましては  
　ツール上部のアイコンにカーソルを置くと説明文が表示されるのでそちらをお読みください。  
　  
　プログラムと同じ場所にある「data」フォルダでテキストデータを管理しています。  
　こちらの直接編集は想定していませんので、自己責任でお願いします。。  
　  
　代わりに全テキストデータをtxtファイルで一括出力する機能を追加しました。  
　ただし現状はリスト名の重複チェックはしていないので被らないようお願いします。  
　  
　ツールの位置とサイズ、各種ツールの設定はAppData内で記憶させています。  
　こちらを参考にしました。  
　https://www.wareko.jp/blog/c-sharp-form-application-save-restore-window-state-position-size  
　  
　不具合報告は下記までお願いします。  
　https://twitter.com/moko_03_25  
　  
　  
**◆更新履歴**  
　  
　2017.11.15 v.1.01  
　　リストアイテムのリネームダイアログをF2キーまたはListBoxダブルクリックで表示  
　　リストアイテム削除時の確認ダイアログ表示（ショートカットキーはDelete）  
　　オートセーブ対応（暫定で10分固定 / オートセーブ無効化は現時点ではできません）  
　  
　2017.11.20 v.1.02  
　　リストアイテム追加時にテキストボックス内でのEnterで確定  
　　テキストを右端で折り返さない設定に変更  
　　ウインドウの分割位置を保存  
　　リストとテキストのフォントの設定の変更・保存に対応  
　　オートセーブ関連の設定の変更・保存に対応  
　  
　2017.11.23 v.1.03  
　　タブスペースに対応  
　　プログラムアイコンを設定  
　  
　2017.11.24 v.1.04  
　　タスクバーのアイコンとツール名表示に対応  
　　上記対応のためにフォームの枠を取り払ってツールのサイズ変更を実装  
　  
　2017.11.27 v.1.05  
　　ツール設定でテキストを右端で折り返す設定に対応  
　　二重起動を禁止していたのを解除  
　  
　2017.11.28 v.1.06  
　　テキストに変更があった際にDirtyマークを表示  
　  
　2018. 1/22 ver.1.06  
　　ツール上部のバージョン表記が間違っていたので修正  
　  
　2018. 5/ 8 ver.1.07  
　　ツールのアクセントカラーがオプションで変更可能に  
　　それに伴いアイコンのアクティブ時の色を修正  
　  
　2018. 5/ 9 ver.1.08  
　　パネルのアクセントカラーが初期化されない不具合を修正  
　　オプション設定での変更がその場ですぐ反映されるよう対応  
　  
　  
**◆そのうち入るかも知れない機能**  
　  
　・リッチテキストボックスに対応  
　　（URLのハイパーリンク表示、太字など文字の装飾、細かいUndo/Redoが標準搭載されているので）  
　・ツールの位置とサイズをできればAppricationの所ではなくテキストデータで保持する  
　・TextBoxのカーソル位置を記憶させる  
　・変更があったら終了時にダイアログボックスを表示する  
　・ListBoxとListBox選択時の背景色を水色ではなくデザインに合った色にする  
　  
　  
**◆使用アイコンについて**  
　  
　こちらのフリーアイコン素材を使用させて頂いています。  
　  
　Free Icon Pack: 375 Retina-Display-Ready Icons  
　https://www.webpagefx.com/blog/web-design/375-retina-display-ready-icons/  
　  
moko