using UnityEngine;
using UnityEngine.UI;

public class Assignment2ThiefMovement : MonoBehaviour
{

    public bool allowMovement;
    public GameObject artPiece;
    public float speed;

    SpriteRenderer thiefBounds;
    

    public Slider batteryHealth;
    public Slider thiefTimer;

    public float decreaseAmount = 1f;

    bool artPieceGrabbed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allowMovement = true;
        artPieceGrabbed = false;
        batteryHealth.value = batteryHealth.maxValue;

        thiefBounds = GetComponent<SpriteRenderer>();

        thiefTimer.value = thiefTimer.maxValue;
        
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;

        if(allowMovement)
        {
            currentPosition.x -= speed * Time.deltaTime;
            transform.position = currentPosition;

            decreaseAmount = 1f;
            
            
        }

        if(!allowMovement)
        {
            batteryHealth.value -= (5 + decreaseAmount) * Time.deltaTime;
            decreaseAmount += 2f * Time.deltaTime;
        }

        if(batteryHealth.value <= 0)
        {
            allowMovement = true;
        }

        if(thiefBounds.bounds.Contains(artPiece.transform.position) && !artPieceGrabbed)
        {
            speed *= -1;
            artPieceGrabbed = true;
            Vector3 rotatePosition = artPiece.transform.eulerAngles;

            rotatePosition.z += 90f;

            artPiece.transform.eulerAngles = rotatePosition;
            
        }

        if(artPieceGrabbed)
        {
            
            artPiece.transform.position = new Vector2(currentPosition.x + 0.5f, currentPosition.y + 0.5f);

        }

        thiefTimer.value -= 5f * Time.deltaTime;

        if(thiefTimer.value <= 0)
        {
            Destroy(gameObject);
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
