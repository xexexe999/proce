using UnityEngine;
using System.Collections;

public class pathmaker : MonoBehaviour {
public  int counter = 0; 
public Transform floorPrefab; 
	public Transform floorPrefab2; 
public Transform pathmakerPrefab; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (counter < 50) {
			float ran = Random.Range (0.0f, 1.0f);
			if (ran < 0.25f) { 
	transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + (Random.Range (80f,90f)), transform.eulerAngles.z); 
			}
				else if (ran < 0.5f && ran > 0.25f) { 
					transform.eulerAngles = new Vector3 (transform.eulerAngles.x,transform.eulerAngles.y - 90f, transform.eulerAngles.z); 

			}else if (ran < 0.9f && ran > 0.7f) { 
				transform.eulerAngles = new Vector3 (transform.eulerAngles.x + (Random.Range (90f,91f)),transform.eulerAngles.y, transform.eulerAngles.z); 
				
			}
			 else if (ran > 0.85f) { 
						Instantiate (pathmakerPrefab, transform.position, transform.rotation); 
				}
			Instantiate (floorPrefab, transform.position, transform.rotation); 
			transform.Translate (0f, 0f, 5f); 
			Instantiate (floorPrefab2, transform.position, transform.rotation); 
				transform.Translate (0f, 0f, 5f); 
			    counter++; 

			}
		else {
			Destroy (this.gameObject); 
		}
		
	}}

