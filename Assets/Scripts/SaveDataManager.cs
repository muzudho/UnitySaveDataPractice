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
