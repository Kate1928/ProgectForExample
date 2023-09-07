using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanics : MonoBehaviour
{
    public float JumpForse = 10;
    public Rigidbody2D rb;
    public float Speed = 7;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        //audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.Translate(Speed * Time.deltaTime, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetTouch(0).phase == TouchPhase.Began)   
        {
            rb.AddForce(Vector2.up * JumpForse, ForceMode2D.Impulse);
        }
    }


}
