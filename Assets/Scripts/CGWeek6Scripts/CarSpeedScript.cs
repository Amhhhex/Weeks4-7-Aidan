using UnityEngine;

public class CarSpeedScript : MonoBehaviour
{

    public float speed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 currentPosition = transform.position;

        currentPosition.x += speed * Time.deltaTime;


        if (Camera.main.WorldToScreenPoint(currentPosition).x > Screen.width)
        {
            float currentYPosition = currentPosition.y;

            float xPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;

            currentPosition.x = xPosition;
        }

        transform.position = currentPosition;
        
    }
}
