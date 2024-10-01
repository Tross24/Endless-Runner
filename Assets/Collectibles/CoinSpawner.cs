using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public Vector2 coinOffset = new Vector2(0, 1);
    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void SpawnCoin()
    {
        Vector3 coinposition = transform.position + (Vector3)coinOffset;
        Instantiate(coinPrefab, coinposition ,Quaternion.identity);
    }
}
