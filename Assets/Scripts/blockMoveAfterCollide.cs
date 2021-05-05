using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMoveAfterCollide : MonoBehaviour
{
    public GameObject block;//the block which is to be moved
    

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.name == "little_box") {
			block.transform.position = new Vector3(block.transform.position.x, 
													block.transform.position.y - 2f,
													 block.transform.position.z
													);
			Destroy(transform.gameObject);
		}

    }
}
