using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    Vector2 currentPosition;
    public Canvas playerCanvas;
    public Transform npcTransform;
    public float movementValue = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        currentPosition = transform.position;

        if (Vector2.Distance(npcTransform.position, transform.position) < 1)
        {
            playerCanvas.gameObject.SetActive(true);
        }
        else
        {
            playerCanvas.gameObject.SetActive(false);
        }

         

        Vector2 modifiedPosition = Vector2.zero;

        if (Keyboard.current.rightArrowKey.isPressed)
        {

            modifiedPosition.x += movementValue * Time.deltaTime;
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            modifiedPosition.x -= movementValue * Time.deltaTime;
        }

        if(Keyboard.current.upArrowKey.isPressed)
        {
            modifiedPosition.y += movementValue * Time.deltaTime;
        }

        if(Keyboard.current.downArrowKey.isPressed)
        {
            modifiedPosition.y -= movementValue * Time.deltaTime;
        }

        currentPosition += modifiedPosition;

        transform.position = currentPosition;
        
    }
}
