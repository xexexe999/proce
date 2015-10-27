using UnityEngine;
using System.Collections;
//INSTANTIATE MEANS CLONE
public class instantiateDemo : MonoBehaviour {
	public Transform original;
	int numberofClones = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Instantiate(original,Random.insideUnitSphere, Quaternion.Euler(Random.Range (0f,360f),Random.Range (0,360),Random.Range (0,360)));
		            numberofClones++;
		}
}
