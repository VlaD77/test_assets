using UnityEngine;
using System.Collections;

public class OnOffLight : MonoBehaviour {
	public Light l;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if (Input.GetKey(KeyCode.L)){
			 l.enabled = !l.enabled;
			
		}
	}
}
