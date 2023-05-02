using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelController : MonoBehaviour
{
    public Transform panelMenu;
    
    public void OnTrackingFound()
    {
        panelMenu.gameObject.SetActive(true);
    }
    
    public void OnTrackingLost()
    {
        panelMenu.gameObject.SetActive(false);
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
