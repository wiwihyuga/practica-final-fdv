using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x += xSpeed;
        position.y += ySpeed;
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("destruir");
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "enemies")
        {
            Destroy(gameObject);
        }
    }
}
