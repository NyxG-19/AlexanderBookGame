using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator anim;
    private string curAnim;
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    public BHFrustration fMeter;
    private float animTimer;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        curAnim = "idle";
        animTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector2(speedX, speedY);

        if (curAnim == "hurt")
        {
            animTimer += 1f * Time.deltaTime;
            if (animTimer > .75)
            {
                anim.Play("BHIdle");
                curAnim = "idle";
                animTimer = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "bullet")
        {
            fMeter.cur += 1;
            Destroy(collider.gameObject);
            anim.Play("BHHurt");
            curAnim = "hurt";
            animTimer = 0;
        }
    }
}
