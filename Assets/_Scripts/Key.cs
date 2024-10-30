using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public FrustrationMeter fMeter;
    public Animator anim;
    public KeyTimer kTimer;
    private int curKey;
    private string curKeycode;

    // all possible keys to be pressed
    private string[] animKeys = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P",
                                "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        // run NewKey function to get and display a starting key
        NewKey();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(animKeys[curKey].ToLower())) {
            fMeter.cur -= 300;
            NewKey();
        }
    }

    // randomly chooses a new key and resets the timer for that key
    public void NewKey()
    {
        // range is from 9-34 to only pick letters. in testing, the numbers were often confused for letters
        curKey = Random.Range(9, 35);
        anim.Play(animKeys[curKey]);
        kTimer.cur = 0;
    }
}
