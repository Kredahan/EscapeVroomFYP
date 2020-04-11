using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerOpen1 : MonoBehaviour
{

    Animator anim;
    public GameObject Jack;
    public GameObject Hint2;
    public GameObject Lightbulb;
    public GameObject LightHint;

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
        if (other.gameObject.tag == "Key1")
        {
            anim.SetTrigger("OpenDoor");
            Hint2.SetActive(true);
            Jack.SetActive(true);
            Lightbulb.SetActive(true);
            LightHint.SetActive(true);
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
