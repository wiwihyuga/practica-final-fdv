using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusMovement : MonoBehaviour
{

    public Animator animator;
    public int damage = 0;
    public GameObject bullet;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > this.transform.position.x)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "playerBullet")
        {
            Debug.Log("entra trigger");
            
            damage += 1;
            if (damage >= 3)
            {
                animator.SetTrigger("colision");
                
                
            }
        }
    }
    public void DestroyOctopus()
    {
        Destroy(gameObject);
    }

    public void Shoot()
    {
        GameObject bulletPool = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        if (this.gameObject.GetComponent<SpriteRenderer>().flipX)
        {

            bulletPool.GetComponent<FireController>().xSpeed = +0.01f;
        }
        else
        {
            bulletPool.GetComponent<FireController>().xSpeed = -0.01f;
        }
    }
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("entra trigger");
    //        animator.SetTrigger("noColision");
    //    }
    //}
}
