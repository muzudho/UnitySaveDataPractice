﻿namespace Assets.Scripts.Models.SaveData
{
    using System.Collections.Generic;
    using ModelOfSaveData = Assets.Scripts.Models.SaveData;

    /// <summary>
    /// セーブ・データ
    /// </summary>
    public class Init
    {
        // - その他

        internal Init()
        {
            this.gameObjects = new List<ModelOfSaveData.GameObject>();
        }

        // - フィールド

        // JsonUtilクラスは、Dictionary型には対応していない
        public List<ModelOfSaveData.GameObject> gameObjects;

        // - メソッド

        /// <summary>
        /// ゲームオブジェクトの追加
        /// </summary>
        /// <param name="item"></param>
        public void AddGameObject(ModelOfSaveData.GameObject item)
        {
            this.gameObjects.Add(item);
        }
    }
}
