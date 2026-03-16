using UnityEngine;


/*public class TrainAttack : MonoBehaviour
{
 public float speed = 10f;
 private Transform player;

 void Start()
 {
  player = GameObject.FindGameObjectWithTag("Player").transform;
 }

 void Update()

 {
  if (player != null)
  {
   transform.LookAt(player);
  }

 }
}

*/

public class TrainAttack : MonoBehaviour
{
 public float speed = 16;
 public int direction = 1;

 // called by the spawner to decide if the train goes left or right
 public void SetDirection(int dir)
 {
  direction = dir;
 }

 void Update()
 {
  transform.Translate(Vector2.right * speed * direction  * Time.deltaTime);

  // destroy train when it leaves screen
  if (transform.position.x > 12 || transform.position.x < -12)
  {
   Destroy(gameObject);
  }
 }
 void OnTriggerEnter2D(Collider2D other)
 {
  if (other.CompareTag("Player"))
  {
   Time.timeScale = 1;
   Debug.Log("Game Over!");
  }
 }
}