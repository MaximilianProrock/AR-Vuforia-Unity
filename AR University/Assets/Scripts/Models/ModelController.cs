using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ModelController : MonoBehaviour
{
    public Animator animator;
    public Text helloText, infoAboutAudienceText, infoAboutSponsorText;
    private void AnimationWaving(){animator.Play("Waving"); }
    void Start()
    {
        animator = GetComponent<Animator>();  
        helloText.gameObject.SetActive(false);
        infoAboutAudienceText.gameObject.SetActive(false);
        infoAboutSponsorText.gameObject.SetActive(false);
    }
    public void OnPressedHello()
    {
        helloText.gameObject.SetActive(true);
        infoAboutAudienceText.gameObject.SetActive(false);
        infoAboutSponsorText.gameObject.SetActive(false);
        AnimationWaving();
    }
    public void OnPressedInfoAboutAudience()
    {
        helloText.gameObject.SetActive(false);
        infoAboutAudienceText.gameObject.SetActive(true);
        infoAboutSponsorText.gameObject.SetActive(false);
    }
    public void OnPressedInfoAboutSponsor()
    {
        helloText.gameObject.SetActive(false);
        infoAboutAudienceText.gameObject.SetActive(false);
        infoAboutSponsorText.gameObject.SetActive(true);
    }
}
