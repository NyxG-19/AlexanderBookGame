using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScore : MonoBehaviour
{
    private TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    { 
        scoreText = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(GameControl.control.score.ToString());
    }
}
