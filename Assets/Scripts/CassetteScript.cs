using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteScript : MonoBehaviour
{

    public GameObject StaticCassette; 
    public GameObject GrabbableCassette;
    GameObject obj;
    Animator anim;
    private AudioSource audio;

    void Start()
    {
        obj = GameObject.FindWithTag("CassettePlayButton");
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cassette")
        {
            GetComponent<AudioSource>().Play();
            GrabbableCassette.SetActive(false);
            StaticCassette.SetActive(true);
            anim.SetTrigger("CassetteTrigger");
            obj.GetComponent<CassetteButtonScript>().tapeInCassette = true;
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
