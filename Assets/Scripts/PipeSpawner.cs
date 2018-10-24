using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float maxYpos;
    public float SpawnTime;
    public GameObject pipe;

	// Use this for initialization
	void Start () {
        //StartSpawningPipes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }


    public void StartSpawningPipes()
    {
        InvokeRepeating("SpawnPipe", 0.2f, SpawnTime);
    }

    void SpawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos), 0), Quaternion.identity);
    }

}
