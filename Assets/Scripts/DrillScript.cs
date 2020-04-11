using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillScript : MonoBehaviour
{
    GameObject obj;
    Animator anim;
    private AudioSource audio;

    void Awake()
    {
        obj = GameObject.FindWithTag("KeyHider");
    }

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
        if (other.gameObject.tag == "Drill")
        {
            anim.SetTrigger("UnscrewTrig");
            GetComponent<AudioSource>().Play();
            // audio.Play();
            obj.GetComponent<BoxScript>().unscrewed1 = true;
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
