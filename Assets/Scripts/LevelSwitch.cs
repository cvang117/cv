using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitch : MonoBehaviour
{
    public int currLevel = 0;
    public string[] levelNames = new string[2] { "Level1", "Level2" };
    static LevelSwitch s = null;

    // Start is called before the first frame update
    void Start()
    {
        if (s == null)

            s = this;

        else
            Destroy(this.gameObject);


        DontDestroyOnLoad(this.gameObject);
         }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) {
            currLevel = (currLevel + 1) % 2; //next level
            SteamVR_LoadLevel.Begin(levelNames[currLevel]);
        }
    }
}
