using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public int score;

    private void Awake()
    {
        // this object becomes the game controller if there is none
        // makes this object persist through scene loads
        if (control == null)
        {
            control = this;
            DontDestroyOnLoad(gameObject);
        }
        // if there's already a different game controller, destroys this
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }
}
