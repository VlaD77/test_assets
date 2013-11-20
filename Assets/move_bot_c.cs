using UnityEngine;
using System.Collections;

public class move_bot_c : MonoBehaviour {
	public GameObject player; 
  	public int speed = 2;
	// Use this for initialization
	void Start () {
	player = (GameObject)this.gameObject;	
	
		
	}
	
	// Update is called once per frame
	void Update () {
    var position = player.transform.position; 
	
	player.transform.position += player.transform.forward * speed * Time.deltaTime; 
		if(position.z==player.transform.position.z){
		player.transform.Rotate(Vector3.left * Time.deltaTime);	
		
		}	
		
			}
}
