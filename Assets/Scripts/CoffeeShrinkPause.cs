using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeShrinkPause : MonoBehaviour
{

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
