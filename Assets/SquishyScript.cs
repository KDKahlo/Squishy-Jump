using UnityEngine;
using UnityEngine.UIElements;

public class SquishyMove : MonoBehaviour
{
    //variable to interact with Rigidbody2D component
    public Rigidbody2D SquishyRigidbody;
    public float SquishyMoveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)        {
            SquishyRigidbody.linearVelocity =  Vector2.up * SquishyMoveSpeed;
        }
        
    }
}
