namespace Assets.Scripts.Models.SaveData
{
    using UnityEngine;

    /// <summary>
    /// UnityのGameObjectをラッピング
    /// </summary>
    [System.Serializable]
    public class GameObject
    {
        // -^ その他

        internal static GameObject FromGameObject(UnityEngine.GameObject gameObject)
        {
            return new GameObject
            {
                name = gameObject.name,
                x = gameObject.transform.position.x,
                y = gameObject.transform.position.y,
                z = gameObject.transform.position.z
            };
        }

        // - フィールド

        public string name;
        public float x;
        public float y;
        public float z;
    }
}
