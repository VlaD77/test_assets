public var bulletImpulse = 300;
 public var shootSpeed = 3; 
 public var bullet : GameObject; 
 public var lastShotTime : float;

 var bull_clone : GameObject;
  function Start() { Destroy(bull_clone);
  lastShotTime = 0;
   
   }
   function Update () {
   
   if (Input.GetKey(KeyCode.Mouse0))
    {
      
    if (Time.time>(lastShotTime)) 
    { 
    Destroy(bull_clone);
     bull_clone = Instantiate(bullet, transform.position, transform.rotation); 
     Physics.IgnoreCollision(bull_clone.collider, collider);
     bull_clone.rigidbody.AddForce(transform.forward*bulletImpulse, ForceMode.Impulse);
      lastShotTime = Time.time; 
     
      
      } 
      
      }
      
      }