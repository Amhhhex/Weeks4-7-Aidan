using UnityEngine;
using UnityEngine.UI;

public class Assignment2ThiefMovement : MonoBehaviour
{

    public bool allowMovement;
    public GameObject artPiece;
    public float speed;

    public Slider batteryHealth;

    bool artPieceGrabbed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allowMovement = true;
        artPieceGrabbed = false;
        batteryHealth.value = batteryHealth.maxValue;
        
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

        if(!allowMovement)
        {
            batteryHealth.value -= 5 * Time.deltaTime;
        }

        if(batteryHealth.value <= 0)
        {
            allowMovement = true;
        }

        if(Vector2.Distance(currentPosition, artPiece.transform.position) < 1 && !artPieceGrabbed)
        {
            speed *= -1;
            artPieceGrabbed = true;
            Vector2 rotatePosition = transform.eulerAngles;

            rotatePosition.y += 180f;

            transform.eulerAngles = rotatePosition;
            
        }

        if(artPieceGrabbed)
        {
            
            artPiece.transform.position = new Vector2(currentPosition.x + 0.5f, currentPosition.y + 0.5f);

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
