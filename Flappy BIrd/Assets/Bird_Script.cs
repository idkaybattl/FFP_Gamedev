using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    public float flapstrenght = 20;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Bob Birdington"; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody2D.linearVelocity = Vector2.up * flapstrenght;
        }
        
    }
}
