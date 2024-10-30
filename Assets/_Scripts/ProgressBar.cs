using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[ExecuteInEditMode()]

public class ProgressBar : MonoBehaviour
{

    public float max;
    public float cur;
    public Image mask;
    public int fillSpeed;
    public Canvas canvas;

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
            string sceneName = SceneManager.GetActiveScene().name;
            if (sceneName == "GumGame")
            {
                SceneManager.LoadScene("SchoolNarrative");
            }
            else if (sceneName == "SchoolGame")
            {
                SceneManager.LoadScene("BHNarrative");
            }
            else if (sceneName == "BHGame")
            {
                SceneManager.LoadScene("Ending");
            }
        }
    }

    // increases current fullness of progress bar according to the set speed with relation to deltaTime
    void IncreaseFill()
    {
        cur += fillSpeed * Time.deltaTime;
    }

    // updates visuals with the new current fill amount
    void GetCurrentFill()
    {
        float newFillAmt = cur / max;
        mask.fillAmount = newFillAmt;
    }
}