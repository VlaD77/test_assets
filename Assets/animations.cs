using UnityEngine;
using System.Collections;

public class animations : MonoBehaviour {
	int change;
	// Use this for initialization
	void Start () {
		change=0;
	var mousePos = Input.mousePosition;
mousePos.x -= Screen.width/2;
mousePos.y -= Screen.height/2;
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(Input.GetKeyDown(KeyCode.LeftShift)){
	    if (Input.GetKey(KeyCode.W))
		{
			
		animation.Play("Run");
		animation.wrapMode = WrapMode.Loop;
			}
		}
		
	    if (Input.GetKey(KeyCode.W)&&Input.GetKeyUp(KeyCode.LeftShift))
		{
			
			animation.Play("Walk");
		animation.wrapMode = WrapMode.Loop;
			
			
	}
	if(Input.GetKeyDown(KeyCode.Space)){
			animation.wrapMode = WrapMode.Default;
			animation.Play("Jump");
			//animation.wrapMode = WrapMode.Loop;
			
		}
		if(Input.GetKeyDown(KeyCode.Mouse0)){
		animation.wrapMode = WrapMode.Default;
		animation.Play("Single_Shot");	
			
		}
		if(Input.GetKeyDown(KeyCode.R)){
		animation.wrapMode = WrapMode.Default;
		animation.Play("Reload");	
			
		}
		
	}	
			
		
		
	
}
