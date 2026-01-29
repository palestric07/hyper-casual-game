using UnityEngine;

public class platformscript : MonoBehaviour
{
    public float speedforce = 2f;
    public float boundary = 7f;

    public bool is_platform;
    public bool is_breakableplatform;
    public bool is_deadplatform;

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.y += speedforce * Time.deltaTime;
        transform.position = temp;

        if (temp.y > boundary)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        // ✅ Breakable Platform
        if (is_breakableplatform)
        {
            Destroy(gameObject); // player lagte hi toot jaye
        }

        // ❌ Dead Platform
        if (is_deadplatform)
        {
            collision.gameObject.GetComponent<player>().Die();
        }

        // ✅ Simple platform
        // is_platform ke liye kuch extra nahi chahiye
    }
}
