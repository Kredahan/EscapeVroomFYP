using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvRemoteScript : MonoBehaviour
{

    public GameObject StaticBattery; //The static battery that appears in the back of the remote
    public GameObject MoveableBattery;
    public GameObject EscapeCode;
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
        if (other.gameObject.tag == "MoveableBattery")
        {
            GetComponent<AudioSource>().Play();
            MoveableBattery.SetActive(false);
            StaticBattery.SetActive(true);
            EscapeCode.SetActive(true);
        }
    }
}
