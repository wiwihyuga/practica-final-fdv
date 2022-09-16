using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    public CinemachineVirtualCamera vm;
    public CrabController crab;
    public CinemachineConfiner confiner;
    public GameObject background;
    public ProgressBar pb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            vm.gameObject.SetActive(true);
            crab.CreateAttacks();
            confiner.gameObject.SetActive(true);
            background.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            pb.gameObject.SetActive(true);
        }
    }
}
