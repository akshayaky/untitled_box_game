using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_spawn : MonoBehaviour
{
	public GameObject gb;
	public Vector3 _randomPosition = new Vector3(17f, 61f, 0f);

	public Vector3 min;
	public Vector3 max;

	private int maxCount = 8;
	private int count = 0;

    void Start()
	{
   		Invoke("SpawnBox", Random.Range(1,3));
	}

 
	void SpawnBox()
	{
	 	if(count == maxCount)
	 	{
	 		return;
	 	}
		Invoke("SpawnBox", Random.Range(1,3)); // Spawn new box in a random amount of time
	 	_randomPosition = new Vector3(UnityEngine.Random.Range(min.x, max.x), 
	 									UnityEngine.Random.Range(min.y, max.y), 0f);
		Instantiate(gb, _randomPosition , Quaternion.identity);
		gb.transform.eulerAngles = new Vector3(
					    		gb.transform.eulerAngles.x,
					    		gb.transform.eulerAngles.y,
					    		gb.transform.eulerAngles.z + 100
								);
		count += 1;
	}

    
}
