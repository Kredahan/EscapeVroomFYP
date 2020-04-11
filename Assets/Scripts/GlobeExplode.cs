using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeExplode : MonoBehaviour
{
    public GameObject moveableCarmen;
    public GameObject staticCarmen;
    public GameObject explosion;
    public GameObject key;
    public bool explode;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        explode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (explode == true)
        {
            StartCoroutine(ExecuteAfterTime(3));
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Carmen")
        {
            explode = true;
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        moveableCarmen.SetActive(false);
        staticCarmen.SetActive(true);

        yield return new WaitForSeconds(time);

        GetComponent<AudioSource>().Play();
        staticCarmen.SetActive(false);
        explosion.SetActive(true);
        key.SetActive(true);
        explode = false;
        gameObject.SetActive(false);
    }
}
