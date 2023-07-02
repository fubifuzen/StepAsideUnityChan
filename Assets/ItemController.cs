using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    // Start is called before the first frame update
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z < player.transform.position.z)
        {
            Debug.Log("complete!");
            Destroy(gameObject);
        }
    }
}