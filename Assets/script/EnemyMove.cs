using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// オブジェクトに紐付いている関数
public class EnemyMove : MonoBehaviour
{

    // 更新用の関数
    void Update()
    {

        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;


        pos.z -= 0.30f;    // z座標へ0.01加算

        myTransform.position = pos;  // 座標を設定
    }
}