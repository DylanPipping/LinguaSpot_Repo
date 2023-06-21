using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProps : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] spawnPropsPrefabs;
    public GameObject[] spawnClonePropsPrefabs;

    private void Start()
    {
        spawnPropsAtLocation();
    }

    void spawnPropsAtLocation()
    {
        spawnClonePropsPrefabs[0] = Instantiate(spawnPropsPrefabs[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
    }
}
