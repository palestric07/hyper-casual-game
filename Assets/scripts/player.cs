using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 4f;        // left right speed
    public float fallSpeed = -10f;       // slow fall speed
    public float maxFallSpeed = -10f;    // limit fall speed

    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // hum khud fall control kar rahe hain
    }

    void Update()
    {
        if (isDead) return;

        Move();
        SlowFall();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal"); // A/D ya ← →
        rb.linearVelocity = new Vector2(x * moveSpeed, rb.linearVelocity.y);
    }

    void SlowFall()
    {
        float newY = rb.linearVelocity.y + fallSpeed * Time.deltaTime;
        newY = Mathf.Clamp(newY, maxFallSpeed, 0f);
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, newY);
    }

    public void Die()
    {
        isDead = true;
        Debug.Log("Player Dead");
        Time.timeScale = 0f; // game over
    }
}
