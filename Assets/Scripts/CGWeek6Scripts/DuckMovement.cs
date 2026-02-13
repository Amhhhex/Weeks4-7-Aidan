using UnityEngine;
using UnityEngine.InputSystem;

public class DuckMovement : MonoBehaviour
{

    public float speed = 3f;

    public GameObject carSpawner;

    public Transform playerSpawnPoint;

    public CarSpawnerScript carSpawnerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        carSpawnerScript = carSpawner.GetComponent<CarSpawnerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 currentPosition = transform.position;


        if(Keyboard.current.leftArrowKey.isPressed)
        {
            currentPosition.x -= speed * Time.deltaTime;
        }

        if(Keyboard.current.rightArrowKey.isPressed)
        {
            currentPosition.x += speed * Time.deltaTime;
        }

        if(Keyboard.current.upArrowKey.isPressed)
        {
            currentPosition.y += speed * Time.deltaTime;

        }
        
        if(Keyboard.current.downArrowKey.isPressed)
        {
            currentPosition.y -= speed * Time.deltaTime;    
        }

        transform.position = currentPosition;  


        for(int i = 0; i < carSpawnerScript.cars.Count; i++)
        {
            SpriteRenderer bounds = carSpawnerScript.cars[i].GetComponent<SpriteRenderer>();

            if (bounds.bounds.Contains(transform.position))
            {
                transform.position = playerSpawnPoint.position;
            }

        }

    }
}
