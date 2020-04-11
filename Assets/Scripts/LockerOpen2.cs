using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerOpen2 : MonoBehaviour
{
    Animator anim;
    public GameObject PianoHint;
    public GameObject Cassette;

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
        if (other.gameObject.tag == "Key2")
        {
            anim.SetTrigger("OpenDoor");
            PianoHint.SetActive(true);
            Cassette.SetActive(true);
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
