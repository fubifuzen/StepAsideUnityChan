using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    // Start is called before the first frame update
    private GameObject player;

    private void Start()
    {
        // プレイヤー（ユニティちゃん）を取得
        player = GameObject.Find("unitychan");
    }

    private void Update()
    {
        // プレイヤーが通り過ぎて画面外に出たアイテムを破棄
        if (transform.position.z < player.transform.position.z)
        {
            Debug.Log("complete!");
            Destroy(gameObject);
        }
    }
}