using System.Collections.Generic;
using UnityEngine;

public class CoinPool : MonoBehaviour
{
    public static CoinPool SharedInstance;
    public List<GameObject> poolList;
    public GameObject coinPrefab;
    public int amountToPool;
    public bool expandPool = true;

    private void Awake()
    {
        SharedInstance = this;
    }

    private void Start()
    {
        poolList = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(coinPrefab);
            obj.transform.SetParent(gameObject.transform);
            obj.SetActive(false);
            poolList.Add(obj);
        }
    }

    public GameObject GetPooledCoin()
    {
        foreach (var coin in poolList)
            if (!coin.activeInHierarchy)
                return coin;

        if (expandPool)
        {
            GameObject obj = Instantiate(coinPrefab);
            obj.transform.SetParent(gameObject.transform);
            obj.SetActive(false);
            return obj;
        }
        else
            return null;
    }
}
