using UnityEngine;

public class Assignment2ThiefMovement : MonoBehaviour
{

    public bool allowMovement;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allowMovement = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 currentPosition = transform.position;



        if(allowMovement)
        {
            currentPosition.x -= speed * Time.deltaTime;
            transform.position = currentPosition;   
        }
        
    }


    public void lightSwitchOn()
    {
        if (allowMovement)
        {
            allowMovement = false;
        }
        else
        {
            allowMovement = true;
        }

    }
}
