using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    private float velocidadvert;
    private float velocidadhor;
    private float speed = 3f;
    public GameObject bullet;
    public ProgressBar pb;
    // Start is called before the first frame update
    void Start()
    {
        pb.BarValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        velocidadhor = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 movement = new Vector2(velocidadhor, velocidadvert);
        movement *= Time.deltaTime;

        transform.Translate(movement);

        if (Input.GetButtonDown("Horizontal"))
        {
           // Debug.Log(velocidadhor);
            if (velocidadhor > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
                
                animator.SetBool("right", true);

            }
            else
            {
                //gameObject.GetComponentInChildren.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 180, gameObject.transform.eulerAngles.z);
                this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
                //this.gameObject.transform.Rotate(0f, 180f, 0f);
                animator.SetBool("right", true);
            }

        }
        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
                animator.SetBool("ground", false);
                animator.SetBool("jump", true);
                //animator.SetBool("right", false);
            }
            else
            {
                if(movement  == Vector2.zero)
                {
                    //Debug.Log("Se queda false");
                    animator.SetBool("right", false);
                }

            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("shoot", true);
            GameObject bulletPool = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
            if (this.gameObject.GetComponent<SpriteRenderer>().flipX)
            {
                
                bulletPool.GetComponent<BulletController>().xSpeed = -0.03f;
            }
            else
            {
                bulletPool.GetComponent<BulletController>().xSpeed = 0.03f;
            }
        }
        else
        {
            animator.SetBool("shoot", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            animator.SetBool("ground",true);
            animator.SetBool("jump", false);
        }
        if(collision.gameObject.tag == "enemyBullet"){
            pb.BarValue -= 20; 
        }
        if(pb.BarValue <= 0)
        {
            Debug.Log("entro al quit");
            SceneManager.LoadScene("Menu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemyRock")
        {
            pb.BarValue -= 50;
        }
        if (pb.BarValue == 0)
        {
            Debug.Log("entro al quit");
            SceneManager.LoadScene("Menu");
        }
    }


}
