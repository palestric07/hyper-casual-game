using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{
    private  Rigidbody2D myBody;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player p = collision.gameObject.GetComponent<player>();
            if (p != null)
            {
                p.Die();
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
