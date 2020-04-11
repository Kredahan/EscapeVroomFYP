using UnityEngine;
using UnityEngine.Events;

public class ButtonPress : MonoBehaviour
{
    [System.Serializable]
    public class ButtonEvent : UnityEvent { }

    CodeLock codeLock;
    public float pressLength;
    public bool pressed;
    public ButtonEvent downEvent;
    private AudioSource audio;
   
    Vector3 startPos;
    Rigidbody rb;

    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // If our distance is greater than what we specified as a press
        // set it to our max distance and register a press if we haven't already
        float distance = Mathf.Abs(transform.position.z - startPos.z);
        if (distance >= pressLength)
        {
            // Prevent the button from going past the pressLength
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z - pressLength);
            if (!pressed)
            {
               pressed = true;
               GetComponent<AudioSource>().Play();
               Debug.Log("The Button being pressed is " + this.transform.name);
                string value = this.transform.name;
                codeLock = this.transform.gameObject.GetComponentInParent<CodeLock>();
                codeLock.SetValue(value);
            }
        }
        else
        {
            // If we aren't all the way down, reset our press
            pressed = false;
        }
        // Prevent button from springing back up past its original position
        if (transform.position.z > startPos.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z);
        }
    }
}