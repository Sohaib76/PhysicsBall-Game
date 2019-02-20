using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    
    public float speed;

    public float power;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // if (Input.GetKey(KeyCode.A)) {
            
          //  rb.AddForce = new Vector2(4, 0);


            
        }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            Vector2 jump =  new Vector2(0, 300);
            rb.AddForce(jump * power);
            rb.velocity = new Vector2(0, 0);
        }
        //float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, 0);


            Rigidbody2D rb1 = GetComponent<Rigidbody2D>();
            rb1.AddForce(movement * speed);
    }

}
