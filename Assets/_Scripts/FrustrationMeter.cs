using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrustrationMeter : MonoBehaviour
{

    public float max;
    public float cur;
    public Image mask;
    public int fillSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cur = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
        if (cur < max)
        {
            IncreaseFill();
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    // Increases fill of meter
    void IncreaseFill()
    {
        cur += fillSpeed * Time.deltaTime;
    }

    // sets fillAmount of mask image to the proper fillness of the meter
    void GetCurrentFill()
    {
        float newFillAmt = cur / max;
        mask.fillAmount = newFillAmt;
    }
}
