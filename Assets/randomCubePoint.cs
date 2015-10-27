using UnityEngine;
using System.Collections;

public class randomCubePoint : MonoBehaviour {

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.position = Random.insideUnitSphere * 5f;

	}
}
