using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digging : MonoBehaviour
{
    public GameObject carmen;
    public GameObject hint;
    public bool dropNextHint;
    Animator anim;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        dropNextHint = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dropNextHint == true)
        {
            StartCoroutine(ExecuteAfterTime(2));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shovel")
        {
            anim.SetTrigger("DigTrig");
            dropNextHint = true;
            GetComponent<AudioSource>().Play();
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        carmen.SetActive(true);
        hint.SetActive(true);
        dropNextHint = false;
    }
}
