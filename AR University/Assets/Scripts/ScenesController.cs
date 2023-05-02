using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{

    public void LoadScanScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void LoadInfoScene()
    {
        SceneManager.LoadScene("Info Scene");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
