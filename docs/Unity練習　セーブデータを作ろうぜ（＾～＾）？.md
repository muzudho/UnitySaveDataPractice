# セーブデータの作り方調べ

📖 [Unityでセーブデータを作る方法まとめ](https://qiita.com/kazuki_kuriyama/items/20847a040d5f52835ba6)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　Unity でセーブデータを作る方法を調べようぜ？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　JSONファイルでいいんじゃないか？」  

![ohkina-hiyoko-futsu2.png](https://crieit.now.sh/upload_images/96fb09724c3ce40ee0861a0fd1da563d61daf8a09d9bc.png)  
「　Unity にファイルチューザーが　あんの？」  

📖 [JsonUtility](https://docs.unity3d.com/ja/current/ScriptReference/JsonUtility.html)  
📖 [EditorJsonUtility.ToJson](https://docs.unity3d.com/ja/current/ScriptReference/EditorJsonUtility.ToJson.html)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　ユーティリティーが２種類あるらしい。使ってみようぜ？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　サンプルが無くて　分からんな」  

📖 [【Unity】JsonUtilityを触ってみた](https://logicalbeat.jp/blog/8195/)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　セーブファイルを　１００個ぐらい分けたいとき　どうするんだぜ？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　１つのJSONファイルに　すべて詰め込むんじゃないか？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　容量は　何バイトまで　保存できるんだぜ？」  

![ohkina-hiyoko-futsu2.png](https://crieit.now.sh/upload_images/96fb09724c3ce40ee0861a0fd1da563d61daf8a09d9bc.png)  
「　移植先にもよるんじゃないの？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　Webブラウザーの上で実行するアプリだったら、どこへ保存される？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　それも含めて調査しろだぜ」  

📖 [永続データ ― ゲームの状態と設定を保存する方法](https://blog.unity.com/ja/technology/persistent-data-how-to-save-your-game-states-and-settings)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　保存先の設定をプログラムしないといけないらしいぜ」  

📖 [UnityTechnologies/UniteNow20-Persistent-Data](https://github.com/UnityTechnologies/UniteNow20-Persistent-Data)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　サンプル・プログラムは　これらしいぜ」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　ソース読んだが　使い方　分からん。  
どうやって　クロス・プラットフォーム　のセーブデータを作れる？  
Windows を想定して　ファイルパス書いていいのか？」  

📖 [PlayerPrefsと同様な使い勝手で独自クラスもセーブできる機能実装【Unity】【セーブ】【Json】](https://magnaga.com/2016/04/25/unity-save2/)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　これを真似てみるかだぜ」

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　なんだこのクラスは。真似たくない書き方だな」  

# セーブボタンを置こう

![202303_unity_11-2200--saveDataManager-1.png](https://crieit.now.sh/upload_images/e4257f7c7fa838934b0e7872bd1e8a03640c7bc3cdad4.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　とりあえず　マネージャー・クラスを作る　鉄板のやり方で　サンプルを書き直そう」  

![202303_unity_11-2211--onSave-1.png](https://crieit.now.sh/upload_images/9a772f1c008ffd1d8cd102bbfca6878e640c7e2c2fd3c.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　`OnSave` という　Publicメソッドを作って」  

![202303_unity_11-2211--saveButton-1.png](https://crieit.now.sh/upload_images/ea6bc8e52d8e3c6380c649d8dd603506640c7fc19b479.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　`Save` ボタンをクリックしたら、 `SaveDataManager` クラスの `OnSave` メソッドを呼び出すところまで  
作るのは　鉄板だぜ」  

# マウスで動かせるオブジェクトを置こう

📖 [オブジェクトを掴んで動かす](https://futabazemi.net/notes/unity-mouse_drag)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　上のリンク先の、他人の記事を読めだぜ。  
マウスで動かせるオブジェクトを画面上に置こうぜ？」  

📖 [Unity　マウスからRayを打つ　～可視化もするよ～](https://hakase0274.hatenablog.com/entry/2019/11/12/200000)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　別の記事も読まないと　コードがおかしいぜ」  

![202303_unity_11-2333--inputManager-1.png](https://crieit.now.sh/upload_images/00e9629b65a49f0d5deaa5b759b87a80640c9156da8e5.png)  

![202303_unity_11-2326--script.png](https://crieit.now.sh/upload_images/2830c4ae2e78f66fa1074ea64efa4156640c905f83bd0.png)  

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    /// <summary>
    /// レイを描く距離
    /// </summary>
    float DebugDrawRayDistance = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // マウス右ボタン　押しっぱなし時
        if (Input.GetMouseButton(0))
        {
            // レイ（見えない光線のようなもの）を飛ばす
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                // レイが当たったオブジェクト
                string goName = hit.collider.gameObject.name;
                Debug.Log("右クリック:" + goName);

                // そのオブジェクトの中心位置を、クリックした場所へ移動（カクカクした動き）
                GameObject.Find(goName).transform.position = new Vector3(hit.point.x, hit.point.y, 0);
            }
            else
            {
                Debug.Log("右クリック 外れ");
            }

            // レイを描く
            Debug.DrawRay(ray.origin, ray.direction * DebugDrawRayDistance, Color.green, 5, false);
        }
    }
}
```

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　カクカクしてるが、とりあえず　これで　箱は動くぜ」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　`Update()` じゃなくて、 `LateUpdate()` にすりゃいいんじゃないかだぜ？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　うまくやってくれだぜ」  

# まず、 PlayerPrefs を練習しようぜ？

![202303_unity_12-0002--loadButton-1.png](https://crieit.now.sh/upload_images/33f01c48d2ec58268bc1932413f76681640c98527113f.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　セーブボタンだけあっても練習できない。ロードボタンも追加するぜ」  

`SaveDataManager.cs` :  

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // - イベントハンドラ

    public void OnSave()
    {
        Debug.Log("セーブします");

        var goCube = GameObject.Find("Cube");
        PlayerPrefs.SetFloat("x", goCube.transform.position.x);
        PlayerPrefs.SetFloat("y", goCube.transform.position.y);
        PlayerPrefs.SetFloat("z", goCube.transform.position.z);
    }

    public void OnLoad()
    {
        Debug.Log("ロードします");

        var goCube = GameObject.Find("Cube");
        var x = PlayerPrefs.GetFloat("x");
        var y = PlayerPrefs.GetFloat("y");
        var z = PlayerPrefs.GetFloat("z");
        goCube.transform.position = new Vector3(x, y, z);
    }
}
```

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　これで　思ってるように　セーブとロードは　でけた」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　バカでかい容量のセーブをしたいとき　こんなシンプルな構造で　対応しきれるのかだぜ？
クラスを　シリアライズ／デシリアライズ　して　投げ込めないの？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　`String` 型のセッターに　JSON を投げ込めだぜ」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　そんなこと　していいのかな……」  

# // 書きかけ
# セーブデータの作り方調べ

📖 [Unityでセーブデータを作る方法まとめ](https://qiita.com/kazuki_kuriyama/items/20847a040d5f52835ba6)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　Unity でセーブデータを作る方法を調べようぜ？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　JSONファイルでいいんじゃないか？」  

![ohkina-hiyoko-futsu2.png](https://crieit.now.sh/upload_images/96fb09724c3ce40ee0861a0fd1da563d61daf8a09d9bc.png)  
「　Unity にファイルチューザーが　あんの？」  

📖 [JsonUtility](https://docs.unity3d.com/ja/current/ScriptReference/JsonUtility.html)  
📖 [EditorJsonUtility.ToJson](https://docs.unity3d.com/ja/current/ScriptReference/EditorJsonUtility.ToJson.html)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　ユーティリティーが２種類あるらしい。使ってみようぜ？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　サンプルが無くて　分からんな」  

📖 [【Unity】JsonUtilityを触ってみた](https://logicalbeat.jp/blog/8195/)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　セーブファイルを　１００個ぐらい分けたいとき　どうするんだぜ？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　１つのJSONファイルに　すべて詰め込むんじゃないか？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　容量は　何バイトまで　保存できるんだぜ？」  

![ohkina-hiyoko-futsu2.png](https://crieit.now.sh/upload_images/96fb09724c3ce40ee0861a0fd1da563d61daf8a09d9bc.png)  
「　移植先にもよるんじゃないの？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　Webブラウザーの上で実行するアプリだったら、どこへ保存される？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　それも含めて調査しろだぜ」  

📖 [永続データ ― ゲームの状態と設定を保存する方法](https://blog.unity.com/ja/technology/persistent-data-how-to-save-your-game-states-and-settings)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　保存先の設定をプログラムしないといけないらしいぜ」  

📖 [UnityTechnologies/UniteNow20-Persistent-Data](https://github.com/UnityTechnologies/UniteNow20-Persistent-Data)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　サンプル・プログラムは　これらしいぜ」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　ソース読んだが　使い方　分からん。  
どうやって　クロス・プラットフォーム　のセーブデータを作れる？  
Windows を想定して　ファイルパス書いていいのか？」  

📖 [PlayerPrefsと同様な使い勝手で独自クラスもセーブできる機能実装【Unity】【セーブ】【Json】](https://magnaga.com/2016/04/25/unity-save2/)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　これを真似てみるかだぜ」

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　なんだこのクラスは。真似たくない書き方だな」  

# セーブボタンを置こう

![202303_unity_11-2200--saveDataManager-1.png](https://crieit.now.sh/upload_images/e4257f7c7fa838934b0e7872bd1e8a03640c7bc3cdad4.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　とりあえず　マネージャー・クラスを作る　鉄板のやり方で　サンプルを書き直そう」  

![202303_unity_11-2211--onSave-1.png](https://crieit.now.sh/upload_images/9a772f1c008ffd1d8cd102bbfca6878e640c7e2c2fd3c.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　`OnSave` という　Publicメソッドを作って」  

![202303_unity_11-2211--saveButton-1.png](https://crieit.now.sh/upload_images/ea6bc8e52d8e3c6380c649d8dd603506640c7fc19b479.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　`Save` ボタンをクリックしたら、 `SaveDataManager` クラスの `OnSave` メソッドを呼び出すところまで  
作るのは　鉄板だぜ」  

# マウスで動かせるオブジェクトを置こう

📖 [オブジェクトを掴んで動かす](https://futabazemi.net/notes/unity-mouse_drag)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　上のリンク先の、他人の記事を読めだぜ。  
マウスで動かせるオブジェクトを画面上に置こうぜ？」  

📖 [Unity　マウスからRayを打つ　～可視化もするよ～](https://hakase0274.hatenablog.com/entry/2019/11/12/200000)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　別の記事も読まないと　コードがおかしいぜ」  

![202303_unity_11-2333--inputManager-1.png](https://crieit.now.sh/upload_images/00e9629b65a49f0d5deaa5b759b87a80640c9156da8e5.png)  

![202303_unity_11-2326--script.png](https://crieit.now.sh/upload_images/2830c4ae2e78f66fa1074ea64efa4156640c905f83bd0.png)  

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    /// <summary>
    /// レイを描く距離
    /// </summary>
    float DebugDrawRayDistance = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // マウス右ボタン　押しっぱなし時
        if (Input.GetMouseButton(0))
        {
            // レイ（見えない光線のようなもの）を飛ばす
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                // レイが当たったオブジェクト
                string goName = hit.collider.gameObject.name;
                Debug.Log("右クリック:" + goName);

                // そのオブジェクトの中心位置を、クリックした場所へ移動（カクカクした動き）
                GameObject.Find(goName).transform.position = new Vector3(hit.point.x, hit.point.y, 0);
            }
            else
            {
                Debug.Log("右クリック 外れ");
            }

            // レイを描く
            Debug.DrawRay(ray.origin, ray.direction * DebugDrawRayDistance, Color.green, 5, false);
        }
    }
}
```

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　カクカクしてるが、とりあえず　これで　箱は動くぜ」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　`Update()` じゃなくて、 `LateUpdate()` にすりゃいいんじゃないかだぜ？」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　うまくやってくれだぜ」  

# まず、 PlayerPrefs を練習しようぜ？

![202303_unity_12-0002--loadButton-1.png](https://crieit.now.sh/upload_images/33f01c48d2ec58268bc1932413f76681640c98527113f.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　セーブボタンだけあっても練習できない。ロードボタンも追加するぜ」  

`SaveDataManager.cs` :  

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // - イベントハンドラ

    public void OnSave()
    {
        Debug.Log("セーブします");

        var goCube = GameObject.Find("Cube");
        PlayerPrefs.SetFloat("x", goCube.transform.position.x);
        PlayerPrefs.SetFloat("y", goCube.transform.position.y);
        PlayerPrefs.SetFloat("z", goCube.transform.position.z);
    }

    public void OnLoad()
    {
        Debug.Log("ロードします");

        var goCube = GameObject.Find("Cube");
        var x = PlayerPrefs.GetFloat("x");
        var y = PlayerPrefs.GetFloat("y");
        var z = PlayerPrefs.GetFloat("z");
        goCube.transform.position = new Vector3(x, y, z);
    }
}
```

📺 [開発中画面](https://twitter.com/muzudho1/status/1634576987200294912?s=20)  

📅 2023-03-12 sun 00:29  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　これで　思ってるように　セーブとロードは　でけた」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　バカでかい容量のセーブをしたいとき　こんなシンプルな構造で　対応しきれるのかだぜ？
クラスを　シリアライズ／デシリアライズ　して　投げ込めないの？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　`String` 型のセッターに　JSON を投げ込めだぜ」  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　そんなこと　していいのかな……」  

# まず、セーブ・スロットを３つにしようぜ？

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　セーブ・ファイルって　複数個　持ちたいよな」  

![ohkina-hiyoko-futsu2.png](https://crieit.now.sh/upload_images/96fb09724c3ce40ee0861a0fd1da563d61daf8a09d9bc.png)  
「　自分用、弟用、クリアー・データ用よね」  

📖 [【Unity uGUI】ドロップダウン（Dropdown）を使用してオプションを選択する方法](https://xr-hub.com/archives/12118)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　とりあえず　ドロップダウン　の作り方を調べるか」  

![202303_unity_12-1235--dropdown-1.png](https://crieit.now.sh/upload_images/6619beb770fc600aaac4306532da6a40640d48ef7f139.png)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　さて、何を　どうすればいいのか？」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　UI は、スクリプトから　操作したいよな」  

📖 [【Unity】ドロップダウンの表示テキストを変える](https://www.ame-name.com/archives/12633)  

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　何かをやろうとしても、はて、と分からんことばっかりで　つらい。調べる」  

![202303_unity_12-1513--saveSlot.png](https://crieit.now.sh/upload_images/703c29c8ddd6fae41458a81f8cf5c3f5640d6d9f90a70.png)  

📅 2023-03-12 sun 15:14  

`SaveDataManager.cs` :  

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveDataManager : MonoBehaviour
{
    TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown = GameObject.Find("Save Slot Dropdown").GetComponent<TMP_Dropdown>();

        // ドロップダウンリストのラベル
        dropdown.options[0].text = "Save Data 1";
        dropdown.options[1].text = "Save Data 2";
        dropdown.options[2].text = "Save Data 3";

        // コンボボックスのラベル
        //
        // - 最初に選択されている項目に合わせないと挙動がおかしくなる
        dropdown.captionText.text = dropdown.options[0].text;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // - フィールド

    string[] gameObjectNamesToSave = new string[]
    {
        "Red Cube",
        "Green Cube",
        "Blue Cube",
    };

    // - イベントハンドラ

    public void OnSave()
    {
        Debug.Log($"{(dropdown.value)}+1番へ、セーブしたい");

        foreach (var gameObjectName in gameObjectNamesToSave)
        {
            var gameObject = GameObject.Find(gameObjectName);
            // ゲームオブジェクトの名前には、いろんな文字が使えるので、区切りなるような文字がない。とりあえずドット区切りにする
            var nameSpace = $"Slot{dropdown.value}.{gameObjectName}";

            PlayerPrefs.SetFloat($"{nameSpace}.x", gameObject.transform.position.x);
            PlayerPrefs.SetFloat($"{nameSpace}.y", gameObject.transform.position.y);
            PlayerPrefs.SetFloat($"{nameSpace}.z", gameObject.transform.position.z);
        }
    }

    public void OnLoad()
    {
        Debug.Log($"{(dropdown.value)}+1番から、ロードしたい");

        foreach (var gameObjectName in gameObjectNamesToSave)
        {
            var gameObject = GameObject.Find(gameObjectName);
            // ゲームオブジェクトの名前には、いろんな文字が使えるので、区切りなるような文字がない。とりあえずドット区切りにする
            var nameSpace = $"Slot{dropdown.value}.{gameObjectName}";

            gameObject.transform.position = new Vector3(
                PlayerPrefs.GetFloat($"{nameSpace}.x"),
                PlayerPrefs.GetFloat($"{nameSpace}.y"),
                PlayerPrefs.GetFloat($"{nameSpace}.z"));
        }
    }
}
```

![ramen-tabero-futsu2.png](https://crieit.now.sh/upload_images/d27ea8dcfad541918d9094b9aed83e7d61daf8532bbbe.png)  
「　👆　よし、ドロップ・ダウン・リストの使い方を覚えたぜ」  

![kifuwarabe-futsu.png](https://crieit.now.sh/upload_images/beaf94b260ae2602ca8cf7f5bbc769c261daf8686dbda.png)  
「　やったぜ！」  

![ohkina-hiyoko-futsu2.png](https://crieit.now.sh/upload_images/96fb09724c3ce40ee0861a0fd1da563d61daf8a09d9bc.png)  
「　やったわね！」  

# // 書きかけ