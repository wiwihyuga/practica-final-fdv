using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public Animator animator;
    private float velocidadvert;
    private float velocidadhor;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("right", true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetButtonDown("Jump"))
            {
                this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
                animator.SetBool("ground", false);
                animator.SetBool("jump", true);
                animator.SetBool("right", false);
            }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            animator.SetBool("ground",true);
            animator.SetBool("jump", false);
            animator.SetBool("right", true);
        }
    }
}
