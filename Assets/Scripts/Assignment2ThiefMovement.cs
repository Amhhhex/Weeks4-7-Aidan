using UnityEngine;
using UnityEngine.UI;

public class Assignment2ThiefMovement : MonoBehaviour
{
    //Bool values, the first enables movement while the second tracks when the painting has been grabbed
    public bool allowMovement;
    bool artPieceGrabbed;

    //GameObject variables
    //One is for the art piece while the second is for the darkLamp
    public GameObject artPiece;
    public GameObject darkLamp;

    //Declaring a spriteRenderer, used to check if the thief overlaps with the painting
    SpriteRenderer thiefBounds;

    
    //Declaration of slider variables
    //Both of the slider values are stored in these public variables
    public Slider batteryHealth;
    public Slider thiefTimer;

    //Declaration of some public float variables
    //The first is used for the speed of the thief
    //The second is used to decrease the battery health
    public float speed;
    public float decreaseAmount = 1f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Setting the values of objects to there default/initial values
        allowMovement = true;
        artPieceGrabbed = false;
        batteryHealth.value = batteryHealth.maxValue;

        //Using GetComponent to grab the spriteRenderer off of the thief gameObject
        thiefBounds = GetComponent<SpriteRenderer>();

        //Setting the value of the thief timer slider to it's max value
        thiefTimer.value = thiefTimer.maxValue;

        //Rotating the thief so that it is facing the correct direction
        Vector2 rotateImage = transform.eulerAngles;
        rotateImage.y += 180f;
        transform.eulerAngles = rotateImage;
        
        
    }
    // Update is called once per frame
    void Update()
    {

        //Storing the current position of the thief in a Vector2 variable
        Vector2 currentPosition = transform.position;


        //Checking to see if the thief can move
        //If it's true the thief moves
        if(allowMovement)
        {
            //Move the thief by a specified amount
            currentPosition.x -= speed * Time.deltaTime;
            transform.position = currentPosition;

            //Resetting the value of decreaseAmount to 1
            decreaseAmount = 1f;

            //Setting the darkLamp gameObject to true, making it appear in the scene
            darkLamp.SetActive(true);
            
            
        }

        //If allowMovement is false
        if(!allowMovement)
        {
            //Deactivate the darkLamp game object
            darkLamp.SetActive(false);

            //Start decreasing the value of the batteryHealth sliders value
            batteryHealth.value -= (5 + decreaseAmount) * Time.deltaTime;

            //Increase decrease amount by a specified amount
            //This makes the battery health slider decrease faster the longer it is being used
            decreaseAmount += 2f * Time.deltaTime;
        }

        
        //If the slider has been depleted of it's value
        if(batteryHealth.value <= 0)
        {
            //Set allowMovement to true, forcing the thief to move forward
            allowMovement = true;

            //Activate the dark lamp game object
            darkLamp.SetActive(false);
        }

        //Triggers when the spriterenderer's bounds overlaps with the artPiece's transform position
        if(thiefBounds.bounds.Contains(artPiece.transform.position) && !artPieceGrabbed)
        {
            //Reverse the direction of the thief
            speed *= -1;
            //Set artPieceGrabbed to true, making this only execute once
            artPieceGrabbed = true;

            //Store the transform values of both the thief and the art piece
            Vector3 rotatePosition = artPiece.transform.eulerAngles;
            Vector2 rotateThief = transform.eulerAngles;

            //Rotate both of them
            rotateThief.y += 180f;
            transform.eulerAngles = rotateThief;
            rotatePosition.z += 90f;
            artPiece.transform.eulerAngles = rotatePosition;
            
        }

        //If the art piece has been grabbed
        if(artPieceGrabbed)
        {
            //Make the artPiece follow the thief's transform position but with a slight offset
            artPiece.transform.position = new Vector2(currentPosition.x + 0.5f, currentPosition.y + 0.5f);

        }


        //Decrease the thief Timer by the specified amount over time
        thiefTimer.value -= 5f * Time.deltaTime;

        //If the thief timer has been depleted
        if(thiefTimer.value <= 0)
        {
            //Destroy the thief
            Destroy(gameObject);
        }
    }

    //This is a function used exclusively by the lightSwitch button
    //This function toggles the value of allowMovement from true to false
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
