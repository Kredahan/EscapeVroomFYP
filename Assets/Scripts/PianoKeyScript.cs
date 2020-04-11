using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PianoKeyScript : MonoBehaviour
{
    PianoManager pianoManager;
    public float pressLength;
    public bool pressed;
    private AudioSource audio;
    public string currentKey;
    public int melodyLength;
    


    Vector3 startPos;
    Rigidbody rb;

    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
        melodyLength = 13;
        pianoManager = this.transform.gameObject.GetComponentInParent<PianoManager>();
    }

    void Update()
    {
        // If our distance is greater than what we specified as a press
        // set it to our max distance and register a press if we haven't already
        float distance = Mathf.Abs(transform.position.y - startPos.y);
        if (distance >= pressLength)
        {
            // Prevent the button from going past the pressLength
            transform.position = new Vector3(transform.position.x, startPos.y - pressLength, transform.position.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z - pressLength);
            if (!pressed)
            {
                //bool loopCompleted = false;
                
                pressed = true; // Boolean to signify whether or not the button has been pressed
                GetComponent<AudioSource>().Play(); // sound effect being played
                currentKey = this.transform.name;
                Debug.Log("The Button being pressed is " + currentKey); // Debug for testing
                pianoManager.SetValue(currentKey);


                /* attemptedMelody = pianoManager.attempt; //The key is pressed and the most recent attempt is fetched from the PianoManager
                 currentKey = this.transform.name;
                 tempMelody = attemptedMelody;
                 StringBuilder sb = new StringBuilder(attemptedMelody);
                              // ie: 13 - 1 = 12 , and melody[12] is the second last element
                 for (int i = melodyLength - 1; i >= 0; i--) //Melody Length - 1 because we are starting with the penultimate element of the string
                 {     //ex: [12] = A         ex:[13] = B
                     Debug.Log("i = " + i);
                     Debug.Log("and value = " + tempMelody.Length);
                     sb[i] = tempMelody[i + 1];
                     Debug.Log("The value of i is " + sb[i]);

                     if(i == 0)
                     {
                         loopCompleted = true;
                         sb[melodyLength] = currentKey[0];
                     }
                 }

                 if(loopCompleted == true)
                 {
                     attemptedMelody = sb.ToString(); // need to take out of loop

                     pianoManager.SetValue(attemptedMelody); // need to take out of loop
                 }*/


            }
        }
        else
        {
            // If we aren't all the way down, reset our press
            pressed = false;
        }
        // Prevent button from springing back up past its original position
        if (transform.position.y > startPos.y)
        {
            transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);
        }
    }
}
