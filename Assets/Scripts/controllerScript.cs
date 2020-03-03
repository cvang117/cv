//map buttons to control game


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class controllerScript : MonoBehaviour
{

    protected SteamVR_TrackedObject mTrackedObject = null;
    //public SteamVR_Controller.Device mDevice
    //{
    //    get
    //    {
    //        return SteamVR_Controller.Input((int)mTrackedObject.index);
    //    }
    //}

    void Awake()
    {
        mTrackedObject = GetComponent<SteamVR_TrackedObject>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

 

    // Update is called once per frame
    void Update()
    {
    //    mdevice = steamvr_controller.input((int)mtrackedobject.index);

    //    // triggers 
    //    // down.
    //    if (mdevice.gettouchdown(steamvr_controller.buttonmask.trigger))
    //    {
    //        // basic test code.
    //        print("button pressed :: trigger_down");
    //    }

    //    // up
    //    if (mdevice.gettouchup(steamvr_controller.buttonmask.trigger))
    //    {
    //        print("button pressed :: trigger_up");
    //    }

    //    // vaule.
    //    vector2 triggervalue = mdevice.getaxis(evrbuttonid.k_ebutton_steamvr_trigger);

    //    //grip
    //    // down.
    //    if (mdevice.getpressdown(steamvr_controller.buttonmask.grip))
    //    {
    //        print("button pressed :: grip_down");
    //    }

    //    // up.
    //    if (mdevice.getpressup(steamvr_controller.buttonmask.grip))
    //    {
    //        print("button pressed :: grip_up");
    //    }

    //    //touchpad
    //    // down.
    //    if (mdevice.getpressdown(steamvr_controller.buttonmask.touchpad))
    //    {
    //        print("button pressed :: touchpad_down");
    //    }

    //    // up.
    //    if (mdevice.getpressup(steamvr_controller.buttonmask.touchpad))
    //    {
    //        print("button pressed :: touchpad_up");
    //    }

    //    // mapping the vector2 to the touchpad.
    //    vector2 touchvalue = mdevice.getaxis(evrbuttonid.k_ebutton_steamvr_touchpad);
   // }
}
}
