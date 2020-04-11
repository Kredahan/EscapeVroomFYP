using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutScript : MonoBehaviour
{
    Animator anim;
    private AudioSource audio;
    public bool aboutPressed;
    public GameObject Board;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        aboutPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkAbout();
    }

    void checkAbout()
    {
        if(aboutPressed == true)
        {
            //GetComponent<AudioSource>().Play();
            StartCoroutine(DisplayAbout(30));
        }

    /*if (aboutPressed == false)
        {
            Board.SetActive(false);
        }*/
    }

    IEnumerator DisplayAbout(float time)
    {
        Board.SetActive(true);
        anim.SetTrigger("AboutTrig");
        
        yield return new WaitForSeconds(time);
        
        aboutPressed = false;
        anim.enabled = true;

        yield return new WaitForSeconds(0.5f);
        anim.enabled = false;
        anim.ResetTrigger("AboutTrig");
        Board.SetActive(false);
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
