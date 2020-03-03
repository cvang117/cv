//This script will control the talking animations
//
//
// instead of creating multiple talking scripts for each tasks,
// we need to create one file as an on click event (such as menuscontrol script)
// and add that on click event to each button and assign audio, etc.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkingScript : MonoBehaviour
{

    public Animator CarlsBody;
    public AudioSource objectSource;
    public AudioClip whatToDoClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        CarlsBody.SetBool("Audio", true);
        objectSource.PlayOneShot(whatToDoClip, 0.8f);
        yield return new WaitForSeconds(whatToDoClip.length);
        CarlsBody.SetBool("Audio", false);
    }
}
