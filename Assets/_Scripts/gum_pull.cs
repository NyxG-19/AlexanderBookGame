using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gum_pull : MonoBehaviour
{

    public Animator anim;
    private int hits;
    public FrustrationMeter fMeter;
    private int lastCount;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        hits = 0;
        lastCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hits++;
            GameControl.control.score++;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            anim.Play("gum_pull2");
        }
        else
        {
            anim.Play("gum_pull");
        }

        
        if ((hits % 1) == 0)
        {
            if (lastCount != hits)
            {
                fMeter.cur -= 100;
            }
            lastCount = hits;
        }
    }
}
