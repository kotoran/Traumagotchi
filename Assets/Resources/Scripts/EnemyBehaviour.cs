using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    private Rigidbody2D rb;
    [SerializeField] Vector2 spawnLocation;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        applyForce();
    }

    private void OnEnable()
    {
        //transform.position = spawnLocation;
        applyForce();
    }

    private void applyForce()
    {
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(new Vector2(Random.Range(-101, 101), Random.Range(0, 8)));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Despawner"))
        {
            Destroy(gameObject);
        }
    }
}
