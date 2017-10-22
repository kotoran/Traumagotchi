using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] [Range(0f, 20f)] private float horizontalVelocity = 10.0f;
    [SerializeField] [Range(0f, 20f)] private float verticalVelocity = 10.0f;
    //[SerializeField] [Range(0.0f, .99f)] private float friction = .99f;

    void Update()
    {
        Move();
    }

    public void Move()
    {
        gameObject.transform.Translate(new Vector2(
            Input.GetAxis("Horizontal") * Time.deltaTime * horizontalVelocity,
            Input.GetAxis("Vertical") * verticalVelocity * Time.deltaTime));
    }
}
