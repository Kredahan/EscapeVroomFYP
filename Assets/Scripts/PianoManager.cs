using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoManager : MonoBehaviour
{
    public GameObject EscapeCode;
    public string attempt;
    int melodyLength = 15; // shouldd be 13 for array length, but I'm still not sure how queues index their elements
    int count = 0;
    //Queue attemptedMelody;
    Queue<string> attemptedMelody = new Queue<string>();
    public string correctMelody = "CCGGAAGFFEEDDC";

    void Start()
    {
        //Queue attemptedMelody = new Queue();
    }

    public void checkMelody(string melody)
    {
        if(melody == correctMelody)
        {
            Debug.Log("Correct! You just played Twinkle Twinkle Little Star!");
            EscapeCode.SetActive(true);
        }
    }

    static string ConvertStringArrayToStringJoin(string[] array)
    {
        // Use string Join to concatenate the string elements.
        string result = string.Join("", array);
        return result;
    }

    public void SetValue(string value)
    {
        attemptedMelody.Enqueue(value);
        count++;

        if(count >= melodyLength)
        {
            attemptedMelody.Dequeue();
        }
        string[] arr = attemptedMelody.ToArray();

        if(count >= melodyLength - 1)
        {
            string finalMelody = ConvertStringArrayToStringJoin(arr);
            Debug.Log("The Melody String is: " + finalMelody);
            checkMelody(finalMelody);

        }

        Debug.Log(string.Join(", ", arr));
    }
}
