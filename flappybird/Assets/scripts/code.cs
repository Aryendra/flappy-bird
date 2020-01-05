using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    private bool endgame;
    private Rigidbody2D rb2d;
    public float upforce;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (endgame == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("flap");
            }

        }
    }
    void OnCollisionEnter2D()
    {
        endgame = true;
        anim.SetTrigger("die");
        GameController.instance.BirdDied();
    }
}
