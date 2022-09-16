using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public CinemachineVirtualCamera camera1;
    public CinemachineVirtualCamera camera2;
    public CinemachineVirtualCamera camera3;
    public CinemachineVirtualCamera camera4;
    // Start is called before the first frame update
    private void Awake()
    {
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        camera4.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camera1.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
            camera3.gameObject.SetActive(false);
            camera4.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camera2.gameObject.SetActive(true);
            camera1.gameObject.SetActive(false);
            camera3.gameObject.SetActive(false);
            camera4.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camera3.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
            camera1.gameObject.SetActive(false);
            camera4.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camera3.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
            camera1.gameObject.SetActive(false);
            camera4.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            camera4.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
            camera1.gameObject.SetActive(false);
            camera3.gameObject.SetActive(false);
        }
    }
}
