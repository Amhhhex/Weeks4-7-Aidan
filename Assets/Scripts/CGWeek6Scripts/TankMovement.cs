using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovement : MonoBehaviour
{

    public float speed = 3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 currentPosition = transform.position;

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            currentPosition.x -= speed  * Time.deltaTime;

            transform.position = currentPosition;
        }

        if(Keyboard.current.rightArrowKey.isPressed)
        {
            currentPosition.x += speed * Time.deltaTime;

            transform.position = currentPosition;
        }
        
    }
}
