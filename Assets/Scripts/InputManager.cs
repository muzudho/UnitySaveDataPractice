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
    private void LateUpdate()
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

                // そのオブジェクトの中心位置を、クリックした場所へ移動
                //
                // - マウスを速く動かすと　キューブの外にマウスが外れてしまう（掴んでいたものを放してしまう）
                GameObject.Find(goName).transform.position = new Vector3(hit.point.x, hit.point.y, 0);
            }

            // レイを描く
            Debug.DrawRay(ray.origin, ray.direction * DebugDrawRayDistance, Color.green, 5, false);
        }
    }
}
