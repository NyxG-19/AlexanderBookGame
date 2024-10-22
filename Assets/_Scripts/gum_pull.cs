using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gum_pull : MonoBehaviour
{

    public Animator anim;
    private int hits;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        hits = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.Play("gum_pull2");
            hits++;
        }
        else
        {
            anim.Play("gum_pull");
        }
    }
}
