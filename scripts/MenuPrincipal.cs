using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BotonQuit()
    {
        Debug.Log("quitar");
        Application.Quit();
    }
    // Update is called once per frame
    
}
