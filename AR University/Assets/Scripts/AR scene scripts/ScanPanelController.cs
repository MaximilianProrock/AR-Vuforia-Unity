using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanPanelController : MonoBehaviour
{

    public Transform panelScanMarker;
    // Start is called before the first frame update

    public void OnTrackingFound()
    {
        panelScanMarker.gameObject.SetActive(false);
    }
    
    public void OnTrackingLost()
    {
        panelScanMarker.gameObject.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
