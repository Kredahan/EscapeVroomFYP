using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    //private System.Random _random = new System.Random();
    
    public bool doorUnlocked;
    // Start is called before the first frame update
    void Start()
    {
        doorUnlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("The Generated Door Code is " + GlobalVariables.doorCode);
    }

}
