using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ModelOfSaveData = Assets.Scripts.Models.SaveData;
using Unity.VisualScripting.FullSerializer;

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
        // セーブデータ・モデルの作成
        var saveDataModel = new ModelOfSaveData.Init();

        // 記憶したいゲームオブジェクトを格納
        foreach (var gameObjectName in gameObjectNamesToSave)
        {
            var gameObject = GameObject.Find(gameObjectName);
            var gameObject2 = ModelOfSaveData.GameObject.FromGameObject(gameObject);
            saveDataModel.AddGameObject(gameObject2);
        }

        // JSON文字列化（シリアライズ）
        var jsonText = JsonUtility.ToJson(saveDataModel);

        // 保存
        Debug.Log($"{(dropdown.value)}+1番へ、セーブしたい。 Json:{jsonText}");
        PlayerPrefs.SetString($"Slot{dropdown.value}", jsonText);
    }

    public void OnLoad()
    {
        // 読取（JSONテキスト取得）
        var jsonText = PlayerPrefs.GetString($"Slot{dropdown.value}");
        Debug.Log($"{(dropdown.value)}+1番から、ロードしたい。 Json:{jsonText}");

        // セーブデータ・モデルへ復元
        var saveDataModel2 = JsonUtility.FromJson<ModelOfSaveData.Init>(jsonText);
        if (saveDataModel2==null)
        {
            // 復元できません
            Debug.Log($"{(dropdown.value)}+1番 ロードできませんでした。 Json:{jsonText}");
            return;
        }

        // 記憶されているゲームオブジェクトを取出し
        foreach (var gameObject2 in saveDataModel2.gameObjects)
        {
            var gameObject = GameObject.Find(gameObject2.name);
            gameObject.transform.position = gameObject2.ToPosition();
        }
    }
}
