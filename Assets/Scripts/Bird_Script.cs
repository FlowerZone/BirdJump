using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    public Rigidbody2D birdRigidBody2D;
    public float flap_strength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidBody2D.velocity = Vector2.up * flap_strength;
        }
        if (transform.position.y > 13 || transform.position.y < -15)
        {
        logic.gameOver();
        }
       
 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
