using UnityEngine;

public class TrainAttack : MonoBehaviour
{
    public float speed = 16f;
    public int direction = 1;
    public bool hasHitPlayer = false;

    public void SetDirection(int dir)
    {
        direction = dir;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (transform.position.x > 12 || transform.position.x < -12)
        {
            if (!hasHitPlayer)
            {
                ScoreManager.instance.AddScore(1);
            }

            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hasHitPlayer = true;
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
    }
}