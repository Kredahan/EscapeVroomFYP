using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDoorScript : MonoBehaviour
{
    Animator anim;
    public bool gameStarted;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkStart();
    }

    void checkStart()
    {
        if (gameStarted == true)
        {
            StartCoroutine(StartGame(3));
        }
    }

    IEnumerator StartGame(float time)
    {
        anim.SetTrigger("StartGameTrig");
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("RedRoom");
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
