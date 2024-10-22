using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gum_pull : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/alexander_gum2");
        }
//else {
//
// SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
// spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/alexander_gum1.png");
// }
    }
}
