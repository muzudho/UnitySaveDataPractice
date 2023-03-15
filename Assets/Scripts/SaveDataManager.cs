using TMPro;
using UnityEngine;
using ModelOfSaveData = Assets.Scripts.Models.SaveData;

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
        var slotNth = dropdown.value + 1;
        Debug.Log($"Save to Slot{(slotNth)}. Json:{jsonText}");
        PlayerPrefs.SetString($"Slot{slotNth}", jsonText);
    }

    public void OnLoad()
    {
        var slotNth = dropdown.value + 1;

        // 読取（JSONテキスト取得）
        //
        // - 保存されていなければ空文字列
        var jsonText = PlayerPrefs.GetString($"Slot{slotNth}");

        // セーブデータ・モデルへ復元
        var saveDataModel2 = JsonUtility.FromJson<ModelOfSaveData.Init>(jsonText);
        if (saveDataModel2==null)
        {
            // 復元できません
            Debug.Log($"Failed to load from Slot{slotNth}");
            return;
        }

        Debug.Log($"Load from Slot{slotNth}. Json:{jsonText}");

        // 記憶されているゲームオブジェクトを取出し
        foreach (var gameObject2 in saveDataModel2.gameObjects)
        {
            var gameObject = GameObject.Find(gameObject2.name);
            gameObject.transform.position = gameObject2.ToPosition();
        }
    }
}
