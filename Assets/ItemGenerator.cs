using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private float generateDistance = 10f; // 生成する距離
    private float generateRange = 10f; // アイテムの生成範囲

    private GameObject unityChan;
    private float lastGeneratedPos; // 最後に生成した位置

    private void Start()
    {
        unityChan = GameObject.Find("unitychan");
        lastGeneratedPos = unityChan.transform.position.z;
    }

    private void Update()
    {
        float distance = unityChan.transform.position.z - lastGeneratedPos;
        if (distance >= generateDistance)
        {
            GenerateItems();
            lastGeneratedPos = unityChan.transform.position.z;
        }
    }

    private void GenerateItems()
    {
        for (float zPos = lastGeneratedPos + generateDistance; zPos < lastGeneratedPos + generateDistance + generateRange; zPos += 5f)
        {
            float xPos = Random.Range(-generateRange, generateRange);
            int item = Random.Range(1, 11);

            if (item <= 2)
            {
                for (float x = -1f; x <= 1f; x += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab, new Vector3(x * xPos, conePrefab.transform.position.y, zPos), conePrefab.transform.rotation);
                }
            }
            else if (item <= 6)
            {
                GameObject coin = Instantiate(coinPrefab, new Vector3(xPos, coinPrefab.transform.position.y, zPos), coinPrefab.transform.rotation);
            }
            else if (item <= 9)
            {
                GameObject car = Instantiate(carPrefab, new Vector3(xPos, carPrefab.transform.position.y, zPos), carPrefab.transform.rotation);
            }
        }
    }
}
