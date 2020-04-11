using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMachineScript : MonoBehaviour
{

    public GameObject Coffee;
    public GameObject TinyHouseSpot;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mug")
        {
            GetComponent<AudioSource>().Play();
            Coffee.SetActive(true);
            TinyHouseSpot.SetActive(true);
        }
    }
}
