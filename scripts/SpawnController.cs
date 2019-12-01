using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
	public GameObject Enemy;
	public float spawnRate = 2f;
	public Transform SpawnPoint;
	public float nextSpawn = 0.0f;
	
    void Start()
    {
		//Instantiate(Enemy, SpawnPoint.position, Quaternion.identity);
    }
	 

	float x;
	int i;
	void Update()
    {
		
		if(Time.time>nextSpawn)
		{
			nextSpawn = Time.time + spawnRate;
			//x = Random.Range (0f, 1f, 0f);
			i++;
		//	Vector3 SpawnPoint = new Vector3 (x, transform.position.y);
			Debug.Log("spawn object: " + i + ", " + nextSpawn );
			Instantiate(Enemy, SpawnPoint.position, Quaternion.identity);
		}
	}
	
}
