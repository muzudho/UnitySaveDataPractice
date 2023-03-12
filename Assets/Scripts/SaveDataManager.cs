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
