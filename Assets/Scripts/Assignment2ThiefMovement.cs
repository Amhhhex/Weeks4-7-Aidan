using UnityEngine;

public class Assignment2ThiefMovement : MonoBehaviour
{

    public bool allowMovement;
    public GameObject artPiece;
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
        Vector2 artPiecePosition = artPiece.transform.position;

        if(allowMovement)
        {
            currentPosition.x -= speed * Time.deltaTime;
            transform.position = currentPosition;   
        }

        if(Vector2.Distance(currentPosition, artPiecePosition) < 1)
        {
            speed *= -1;
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
