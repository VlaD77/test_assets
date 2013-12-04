

 
 var OBJ : GameObject; 
var array_obj : GameObject []=new GameObject[3]; 
var array_enab : int[]; 
var array_vis : int; 

  function Start() {
   
   var array_enab = new int[3];
   
   array_enab [0]=1;
   array_enab [1]=0;
   array_enab [2]=0;
   array_vis =0;
   
  // Debug.Log(array_vis.Length);
   
   }
 
   function Update () {
   
   if (Input.GetKey(KeyCode.Mouse0))
    {
       OBJ.animation.Play("pnch");
      
    }
     if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
{
OBJ.animation.Play("swapsword");
var u:int=0;
array_vis--;
if (array_vis<0) array_vis=2;
while (array_enab[array_vis]==0)
{
array_vis--;
if (array_vis<0) array_vis=2;
//Debug.Log(array_vis);
//Debug.Log(array_enab[array_vis]);
u++;
if (u>5) break;
if (array_enab[array_vis]>0) break;
}
//if ((array_enab[0]==1) && (array_vis!=0))array_vis=2;
//else if ((array_enab[1]==1) && (array_vis!=1))array_vis=0;
//else if ((array_enab[2]==1) && (array_vis!=2))array_vis=1;
Debug.Log(array_vis);
//}
 for (var i: int=0;i<3;i++) array_obj[i].GetComponent(MeshRenderer).enabled = false;
      array_obj[array_vis].GetComponent(MeshRenderer).enabled =true;
}
if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
{
OBJ.animation.Play("swapsword");
var v:int=0;
array_vis++;
if (array_vis>2) array_vis=0;
while (array_enab[array_vis]==0)
{
array_vis++;
if (array_vis>2) array_vis=0;
//Debug.Log(array_vis);
//Debug.Log(array_enab[array_vis]);
v++;
if (v>5) break;
if (array_enab[array_vis]>0) break;;
}
//if ((array_enab[0]==1) && (array_vis!=0))array_vis=1;
//else if ((array_enab[1]==1) && (array_vis!=1))array_vis=2;
//else if ((array_enab[2]==1) && (array_vis!=2))array_vis=0;
Debug.Log(array_vis);
for (var j: int=0;j<3;j++) array_obj[j].GetComponent(MeshRenderer).enabled = false;
      array_obj[array_vis].GetComponent(MeshRenderer).enabled =true;
}
 
      
}