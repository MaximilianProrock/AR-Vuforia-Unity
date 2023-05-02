using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInCanvasController : MonoBehaviour
{

    public Text HelloText;

    public Text InfoText;

    public Text InfoText2;
    
    void Start()
    {
        HelloText.gameObject.SetActive(false);
        InfoText.gameObject.SetActive(false);
        InfoText2.gameObject.SetActive(false);
    }

    public void onPressedHello()
    {
        HelloText.gameObject.SetActive(true);
        InfoText.gameObject.SetActive(false);
        InfoText2.gameObject.SetActive(false);
    }

    public void onPressedInfo()
    {
        HelloText.gameObject.SetActive(false);
        InfoText.gameObject.SetActive(true);
        InfoText2.gameObject.SetActive(false);
    }
    
    public void onPressedInfo1()
    {
        HelloText.gameObject.SetActive(false);
        InfoText.gameObject.SetActive(false);
        InfoText2.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
