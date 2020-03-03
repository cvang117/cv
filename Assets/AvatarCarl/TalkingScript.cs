//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Valve.VR;

//public class TalkingScript : MonoBehaviour
//{

//    public Animator CarlsBody;
//    public AudioSource objectSource;
//    public AudioClip whatToDoClip;

//    public AudioClip removeBattery;
//    public AudioClip unscrew;
//    public AudioClip removeBack;
//    public AudioClip insertRam;
//    public AudioClip putOn;
//    public AudioClip screwIn;
//    public AudioClip placeBattery;

//    //variables needed to control when to call

//    // Start is called before the first frame update
//    void Start()
//    {
//        objectSource = GetComponent<AudioSource>();

//        AudioSource[] sources = GetComponents<AudioSource>();
//        objectSource = sources[0];
//        //NOTE: this needs to be changed to call the correct
//        // audio source when the tasks are completed
//        // -- using whatToDoClip
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //if(Input.GetKeyDown(KeyCode.T)) {
//            Talk();
//        //}
//    }

//    void Talk() {
//        StartCoroutine(Timer());
//    }

//    IEnumerator Timer() {
//        CarlsBody.SetBool("Audio", true);
//        objectSource.PlayOneShot(whatToDoClip, 0.8f);
//        yield return new WaitForSeconds(whatToDoClip.length);
//        CarlsBody.SetBool("Audio", false);
//    }
//}
