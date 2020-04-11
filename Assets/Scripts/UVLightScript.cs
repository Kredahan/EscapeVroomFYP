using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVLightScript : MonoBehaviour
{

    public GameObject GrabbableUV;
    public GameObject StaticUV;
    public GameObject UVLight; // The actual light that gets produced
    public GameObject HintText;

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
        if (other.gameObject.tag == "UVLight")
        {
            GrabbableUV.SetActive(false);
            StaticUV.SetActive(true);
            UVLight.SetActive(true);
            HintText.SetActive(true);
        }
    }
}
