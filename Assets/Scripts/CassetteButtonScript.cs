using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassetteButtonScript : MonoBehaviour
{
    public float pressLength;
    public bool pressed;
    public bool tapeInCassette;
    private AudioSource audio;

    Vector3 startPos;
    Rigidbody rb;

    void Start()
    {
        tapeInCassette = false;
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // If our distance is greater than what we specified as a press
        // set it to our max distance and register a press if we haven't already
        float distance = Mathf.Abs(transform.position.x - startPos.x);
        //float distance = Mathf.Abs(transform.position.z - startPos.z);
        if (distance >= pressLength)
        {
            // Prevent the button from going past the pressLength
            transform.position = new Vector3(startPos.x - pressLength , transform.position.y, transform.position.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z - pressLength);
            if (!pressed)
            {
                pressed = true;

                Debug.Log("The Button being pressed is " + this.transform.name);
                if (tapeInCassette == true)
                {
                    GetComponent<AudioSource>().Play();
                }

            }
        }
        else
        {
            // If we aren't all the way down, reset our press
            pressed = false;
        }
        // Prevent button from springing back up past its original position
        if (transform.position.x > startPos.x)
        {
            transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);
        }

        /*if (transform.position.z > startPos.z)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, startPos.z);
        }*/
    }
}
