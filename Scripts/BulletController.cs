using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D myrigidbody2D;
    public float bulletSpeed = 10f;

    public GameManager myGameManager;

    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myGameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody2D.linearVelocity = new Vector2(bulletSpeed, myrigidbody2D.linearVelocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            myGameManager.addScore();

        }
        else if (collision.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }
}