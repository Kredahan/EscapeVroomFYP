using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyHouseScript : MonoBehaviour
{

    public GameObject GrabbableCoffee;
    public GameObject StaticCoffee;
    public GameObject Key;

   // Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mug")
        {
            GrabbableCoffee.SetActive(false);
            StaticCoffee.SetActive(true);
            //anim.SetTrigger("ShrinkTrig");
            Key.SetActive(true);
        }
    }

    /*void pauseAnimationEvent()
    {
        anim.enabled = false;
    }*/
}
