using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookcaseScript : MonoBehaviour
{ 
    Animator anim;
    public bool bookInShelf;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        bookInShelf = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(bookInShelf == true)
        {
            anim.SetTrigger("BookTrigger");
        }
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
