using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject key;
    public bool activateKey;
    Animator anim;
    public bool unscrewed1;
    public bool unscrewed2;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        unscrewed1 = false;
        unscrewed2 = false;
        activateKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkScrews();
        dropKey();
    }

    void checkScrews()
    {
        if (unscrewed1 == true && unscrewed2 == true)
        {
            anim.SetTrigger("FallTrig");
            activateKey = true;
        }
    }

    
    void dropKey()
    {
        if (activateKey == true)
        {
            key.SetActive(true);
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
