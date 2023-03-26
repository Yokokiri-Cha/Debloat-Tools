# Debloat-Tools
携帯電話キャリアのブロートウェア(プリインストールアプリ)を一括無効化!
2023/3/26 ※追記
## 本ソフトウェアはUSBデバッグをONにしないと動作しません。
簡単な有効化方法
設定アプリ→端末情報→ビルド番号を7回タップ→設定画面のどこかに開発者向け設定が出現します。
開発者向け設定より、USBデバッグをオンにします。

この手順は端末によって若干異なります。"開発者向けオプション (機種名)"と検索すると端末にあった有効化方法が調べられます。

以下は同梱されているreadme.txtです。

# Debloat Tools by 横茶横葉  
## キャリアのアプリを一括無効化!
注意:このソフトはフロントエンドです。各種txt,batファイルが
同じディレクトリに存在しないと正常に動作しません。解凍する際は
、付属するファイルを同じディレクトリにソフトウェア本体と共に解
凍してください。                                              
参考にさせて頂いたサイト一覧//ありがとうございます!//

https://mitanyan98.hatenablog.com/entry/2021/12/02/130220
(Softbank Script,docomo New Brand Script作成補助 ありがとうござい
ます!)
https://blog.itparadise.jp/?p=802
(表示崩れの改善 ありがとうございます!)
https://developer.android.com/studio/command-line/adb?hl=ja
(ADBの公式ドキュメント)

製作者:横茶横葉
https://yokokiri-cha.github.io
https://sites.google.com/view/yokokiri
Developed with Visual Studio 2022
中古品のスマートフォンを買い漁っていたら思いつきました!


## このソフトウェアのご利用にはADB環境が必要です。
### 簡単な導入方法を紹介します。

1.https://developer.android.com/studio/releases/platform-tools?hl=ja
こちらのサイトの下のほうにあるWindows版をポップアップする利用規約に
同意したうえでダウンロードして下さい。

2.ダウンロードしたzipファイルの中から"フォルダ内のファイル全て"を取り
出してこのソフトウェア本体のあるディレクトリにコピーして下さい。
注意:ソフト本体とadb.exeが最低限同じディレクトリに配置されている必要
があります。
adb.exeの".exe"が表示されない場合がありますが、問題ありません。これ
は拡張子を非表示にする設定になっているためです。

これで本ソフト使用準備完了となります!お疲れ様でした!!


-----------よくありそうな質問--------------

Q:なぜADBを最初からパッケージに含めておかないのか
A:ADB等の他者製作プログラム(ADBはGoogle製)を組み込み、配布する際に
は、組み込むプログラムの利用規約を参照し、従う必要があります。しか
し、今回、ADBを含むCommand line toolsの利用規約を参照したところ、
曖昧な表現かつ矛盾した点が見られました。
簡潔に説明すると、利用規約の不十分さから、
ADBをバンドルする(パッケージに含める)ことはできない と個人的に判断
したため です。

このソフトウェアのライセンス
安心して使用して頂きたいと考えたため、このソフトウェアはオープンソ
ースとなっています。私のGithubページにてソースを掲載しています。
また、単純に製作しただけのアプリですので、"リソースファイル以外"は
ライセンスを特に設けていません。ご自由に改変してご利用下さい。(こ
のソフトウェアのソースを他者の迷惑になること、違法行為等に利用する
ことは禁じられています。また、改変したソフトウェアに私のGithubリポ
ジトリのURLを掲載していただけると幸いです!)

©横茶横葉(YokochaYokoha)All Rights Reserved.
Made for everyone!
