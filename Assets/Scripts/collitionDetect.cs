using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collitionDetect : MonoBehaviour
{
	private GameObject gb;
	public GameObject player;
	public Rigidbody2D rb;
	public PhysicsMaterial2D pm2d;

	private Vector3 position;

	public float volume = 0.5f;
    void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "pickup01") {//gravity increase
			gb = col.gameObject;
			rb.gravityScale *= 20;
			Destroy(gb);
		}
		else if(col.gameObject.tag == "pickup02") {//gravity decrease
			gb = col.gameObject;
			rb.gravityScale /= 20;
			Destroy(gb);
		}
		else if(col.gameObject.tag == "pickup11") {//bounciness increase changed to duplicate box
			gb = col.gameObject;
			// pm2d.bounciness = 1f;
			// rb.GetComponent<Collider2D>().sharedMaterial.bounciness = 1f;
			position = transform.position;
			
			Instantiate(player, position , Quaternion.identity);
			Destroy(gb);
			// Destroy(player);
			
		}
		else if(col.gameObject.tag == "pickup12") {//bounciness to 0
			gb = col.gameObject;
			pm2d.bounciness = 0f;
			Destroy(gb);
		}
		else if(col.gameObject.tag == "pickupBig") {//increase size
			gb = col.gameObject;
			transform.localScale *= 2;
			Destroy(gb);
		}
		else if(col.gameObject.tag == "pickupSmall") {//decrese size
			gb = col.gameObject;
			transform.localScale /= 2;
			Destroy(gb);
		}

    }
}
