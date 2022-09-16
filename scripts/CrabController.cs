using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrabController : MonoBehaviour
{
    
    public Animator animator;
    public StoneGenerator stone1;
    public StoneGenerator stone2;
    public StoneGenerator stone3;
    public StoneGenerator stone4;
    public ProgressBar pb;
    // Start is called before the first frame update
    void Start()
    {
        pb.BarValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    public void CreateAttacks()
    {
        InvokeRepeating("ThrowRocks", 10.0f, 15.0f);
    }

    public void ThrowRocks()
    {
        animator.SetBool("PressX", true);
        stone1.Invoke("generateStone", 0.0f);
        stone2.Invoke("generateStone", 3.0f);
        stone3.Invoke("generateStone", 6.0f);
        stone4.Invoke("generateStone", 9.0f);
        this.Invoke("StopAnimation", 10.0f);
    }
    public void StopAnimation()
    {
        animator.SetBool("PressX", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "playerBullet")
        {
            pb.BarValue -= 10;
        }
        
        if (pb.BarValue == 0)
        {
            Debug.Log("entro al quit");
            SceneManager.LoadScene("Menu");
        }
    }
}
