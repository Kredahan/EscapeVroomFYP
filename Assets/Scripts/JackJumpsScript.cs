using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackJumpsScript : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "JackSpot")
        {
            anim.SetTrigger("JackyTrig");
            Debug.Log("Collision between JackyBoy and JackSpot is detected");
            //audio.Play();
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
