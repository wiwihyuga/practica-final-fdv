using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    public GameObject stone;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    

    private void Awake()
    {
        currentSpeed = MinSpeed;
        //generateStone();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void generateStone()
    {
       GameObject StoneIns = Instantiate(stone, transform.position,transform.rotation);
        StoneIns.GetComponent<StoneScript>().stoneGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
