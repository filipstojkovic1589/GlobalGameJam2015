#pragma strict

function Start () {

}

var speed = 0.5f; //how much it shakes
 
function Update()
{
  transform.position.x = Mathf.Sin(Time.time * speed) /2;
}
 