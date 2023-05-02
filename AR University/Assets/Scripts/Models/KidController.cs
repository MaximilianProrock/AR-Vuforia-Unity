using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void animationWaving()
    {
        anim.Play("Waving");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
