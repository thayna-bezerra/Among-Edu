using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Heart;
    public List<GameObject> spawnPoints;

    public void Awake()
    {
        InvokeRepeating("InstantiateOneHeart", 5f, 25f);
    }

    void InstantiateOneHeart()
    {
        while (GameObject.FindGameObjectsWithTag("Vida").Length < 1)
        {
            int index = Random.Range(0, spawnPoints.Count);

            GameObject H = Instantiate(Heart, spawnPoints[index].transform.position, spawnPoints[index].transform.rotation);
            Destroy(H.gameObject, 5f);
        }
    }

}