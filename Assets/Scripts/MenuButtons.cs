using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    GameObject obj;
    GameObject obj2;
    public GameObject exitText;
    public float pressLength;
    public bool pressed;
    private AudioSource audio;
    public string selection;
    private string startSelect = "StartGame";
    private string aboutSelect = "About";
    private string exitSelect = "Exit";

    Vector3 startPos;
    Rigidbody rb;

    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Awake()
    {
        obj = GameObject.FindWithTag("Door");
        obj2 = GameObject.FindWithTag("Board");
    }

    IEnumerator ExitDisplay(float time)
    {
        exitText.SetActive(true);
        yield return new WaitForSeconds(time);
        exitText.SetActive(false); 
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
                pressed = true;
                GetComponent<AudioSource>().Play();
                Debug.Log("The Button being pressed is " + this.transform.name);
                selection = this.transform.name;

                if (selection == startSelect) // If selection == "StartGame"
                {
                    obj.GetComponent<MenuDoorScript>().gameStarted = true;
                    selection = "";

                }

                if (selection == aboutSelect) // If selection == "About"
                {
                    obj2.GetComponent<AboutScript>().aboutPressed = true;
                    selection = "";
                }

                if (selection == exitSelect) // If selection == "About"
                {
                    //obj2.GetComponent<AboutScript>().aboutPressed = true;
                    StartCoroutine(ExitDisplay(4));
                    selection = "";
                }

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
            transform.position = new Vector3(transform.position.x, startPos.y , transform.position.z);
        }
    }


}
