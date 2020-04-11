using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] Puzzle1;
    public GameObject[] Puzzle2;
    public GameObject[] Puzzle3;
    public GameObject[] Puzzle4;


    // Start is called before the first frame update
    void Start()
    {
        Puzzle1[Random.Range(0,2)].SetActive(true);
        Puzzle2[Random.Range(0,2)].SetActive(true);
        Puzzle3[Random.Range(0,2)].SetActive(true);
        Puzzle4[Random.Range(0,2)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
