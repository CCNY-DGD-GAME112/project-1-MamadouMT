using UnityEngine;

public class TrainAttack : MonoBehaviour
{
    public float speed = 16f;
    public int direction = 1;

    private bool scored = false;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SetDirection(int dir)
    {
        direction = dir;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime, Space.World);

        // Train successfully passes the player
        if (!scored && player != null)
        {
            if ((direction == 1 && transform.position.x > player.position.x) || (direction == -1 && transform.position.x < player.position.x)) 
            {
                scored = true;

                if (GameManager.Instance != null)
                {
                    GameManager.Instance.AddScore();
                    Debug.Log("Train Dodged +1");
                }
            }
        }

        // Destroy train when off-screen
        if (transform.position.x > 12f || transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}