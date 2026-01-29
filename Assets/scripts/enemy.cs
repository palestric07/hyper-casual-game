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
            Destroy(collision.gameObject);
        }
    }
}
