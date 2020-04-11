using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CodeLock : MonoBehaviour
{
    public GameObject TvDisplay;
    public GameObject PianoDisplay;
    public GameObject KeypadDisplay;
    private System.Random _random = new System.Random();
    private AudioSource audio;
    int codeLength;
    int placeInCode;

    public string code = "";
    public string attemptedCode;
    public Transform toOpen;

    public float delayTime = 5f;

    private void Start()
    {
        code = _random.Next(0, 9999).ToString("D4");
        codeLength = code.Length;
        DisplayCode();
    }

    void CheckCode()
    {
        if(attemptedCode == code)
        {
            GetComponent<AudioSource>().Play();
            OpenDoor();
            Invoke("DelayedEscape", delayTime);
        }
    }

    void OpenDoor()
    {
        toOpen.Rotate(new Vector3(0, 90, 0), Space.World);
    }

    public void SetValue(string value)
    {
        //DisplayCode();
        placeInCode++;

        if(placeInCode <= codeLength)
        {
            attemptedCode += value;
            KeypadDisplay.GetComponent<TextMesh>().text = attemptedCode;
        }

        if(placeInCode == codeLength)
        {
            CheckCode();

            attemptedCode = "";
            placeInCode = 0;
        }
    }

    public void DisplayCode()
    {
        TvDisplay.GetComponent<TextMesh>().text = "There are " + code + " reasons for you \n to leave this room right now";
        PianoDisplay.GetComponent<TextMesh>().text = code;
    }

    void DelayedEscape()
    {
        SceneManager.LoadScene("Menu");
    }
}
