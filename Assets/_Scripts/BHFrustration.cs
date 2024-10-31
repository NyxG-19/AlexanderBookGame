using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BHFrustration : MonoBehaviour
{

    public float max;
    public float cur;
    public Image mask;
    private float timer;
    private float marker;

    // Start is called before the first frame update
    void Start()
    {
        cur = 0;
        timer = 0f;
        marker = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1f * Time.deltaTime;

        if (timer > marker)
        {
            GameControl.control.score++;
            marker += 0.5f;
        }

        GetCurrentFill();
        if (cur >= max)
        {
            SceneManager.LoadScene("Ending");
        }
    }

    // sets fillAmount of mask image to the proper fillness of the meter
    void GetCurrentFill()
    {
        float newFillAmt = cur / max;
        mask.fillAmount = newFillAmt;
    }
}
