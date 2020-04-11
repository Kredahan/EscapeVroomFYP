using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBookSpotScript : MonoBehaviour
{
    GameObject obj;
    public GameObject GrabbableBook;
    public GameObject StaticBook;
    

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindWithTag("BookShelf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TimeBook")
        {
            GrabbableBook.SetActive(false);
            StaticBook.SetActive(true);
            obj.GetComponent<BookcaseScript>().bookInShelf = true;
        }
    }
}
