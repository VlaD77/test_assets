using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour {
	public string Move;
	public string Simple;
	public GameObject player; 
  public int speed = 5;
	public int jumpSpeed = 5;
	public KeyCode up;
	public   KeyCode down;
	public 	KeyCode left;
	public  KeyCode right;
	public  KeyCode jump;
	
	// Use this for initialization
	void Start () {
	 player = (GameObject)this.gameObject;
		//down=KeyCode.S;
		//up=KeyCode.W;
		//left = KeyCode.A;
		//right = KeyCode.D;
		//jump = KeyCode.Space;
	//	animation.Play(Simple);
		//animation.wrapMode = WrapMode.Loop;
	}
	
	// Update is called once per frame
	void Update () {
		//animation.Play(Simple);
	if (Input.GetKey(up)) 
  { 
  player.transform.position += player.transform.forward * jumpSpeed * Time.deltaTime;
			animation.Play(Move);
			//animation.wrapMode = WrapMode.Loop;
			
  }
		
		
		if (Input.GetKey(down) ) 
  { 
  player.transform.position -= player.transform.forward * jumpSpeed * Time.deltaTime; 
			animation.Play(Move);
			//animation.wrapMode = WrapMode.Loop;
			
  }
		if (Input.GetKey(left)) 
  { 
  transform.Rotate(0,-1* speed*Time.deltaTime, 0);
			animation.Play(Move);
			//animation.wrapMode = WrapMode.Loop;
			
  }
  if (Input.GetKey(right)) 
  { 
  player.transform.Rotate(0, speed*Time.deltaTime, 0);
			animation.Play(Move);
			//animation.wrapMode = WrapMode.Loop;
			
  }
		if (Input.GetKeyDown(jump)) 
  { 
  //player.transform.position += player.transform.up * jumpSpeed; 
  
		animation.Play(Simple);
		animation.wrapMode = WrapMode.Loop;
		}
		//animation.Play(Simple);
	}
	
	// Use this for initialization
	//
	// Update is called once per frame
	//
}
