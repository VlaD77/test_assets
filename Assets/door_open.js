#pragma strict
var OBJ : GameObject;
var b:int=-1; 

function OnTriggerStay (other : Collider) 
{
if (Input.GetKeyDown("f")) {
  
   if (b==-1) b=1; else b=-1; OBJ.animation["door_rot"].speed = b;
   print(b);
   OBJ.animation.Play("door_rot");  
}}
/*
function OnTriggerEnter (other : Collider) 
{
OBJ.animation["door_rot"].speed = 1;
print("1");
OBJ.animation.Play("door_rot");  
}
function OnTriggerExit (other : Collider) 
{
   OBJ.animation["door_rot"].speed = -1;
   print("-1");
   OBJ.animation.Play("door_rot");  
}*/