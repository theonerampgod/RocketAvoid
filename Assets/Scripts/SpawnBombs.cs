﻿using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

    public GameObject bomb;

    void Start()
    {
        StartCoroutine (Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity); //  borders of bomb spawn
            yield return new WaitForSeconds(0.8f); // Interaval for spwan
        }
    }
   
}
