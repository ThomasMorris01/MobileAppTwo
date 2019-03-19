using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 6; i++)
            Instantiate(prefab, new Vector3(0, 0, i* 1.0f), Quaternion.identity);
    }
   
}
