using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that will be attached to the empty toy spot to act as a trigger for the Jack in the Box Gameobject

public class JackMoveScript : MonoBehaviour
{

    public GameObject StaticJack; //The Jack in the box that will be activated once the moveable Jack collides with the empty toy spot
    public GameObject MoveableJack; //The Jack in the box that will be deactivated once the moveable Jack collides with the empty toy spot
    public GameObject Locker;
    public GameObject Hint;
    public GameObject TVHint;
    public GameObject Battery;
    public bool activateStaticJack;
    public bool deactivateMoveableJack;
    public bool dropNextHint;

    // Start is called before the first frame update
    void Start()
    {
        activateStaticJack = false;
        deactivateMoveableJack = false;
        dropNextHint = false;
    }

    // Update is called once per frame
    void Update()
    {
        activateJack();
        deactivateJack();
        if(dropNextHint == true)
        {
            StartCoroutine(ExecuteAfterTime(2));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GrabbableJack")
        {
            activateStaticJack = true;
            deactivateMoveableJack = true;
            dropNextHint = true;
            // audio.Play();
           // obj.GetComponent<BoxScript>().unscrewed1 = true;
        }
    }


    void activateJack()
    {
        if (activateStaticJack == true)
        {
            StaticJack.SetActive(true);
        }
    }

    void deactivateJack()
    {
        if (deactivateMoveableJack == true)
        {
            MoveableJack.SetActive(false);
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Locker.SetActive(true);
        Hint.SetActive(true);

        yield return new WaitForSeconds(time);

        TVHint.SetActive(true);
        Battery.SetActive(true);
        dropNextHint = false;
    }
}
