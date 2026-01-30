using UnityEngine;

public class Flipper : MonoBehaviour
{

    public float direction = 1f;

    public float speed;

    bool allowMovement = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {

        if (allowMovement)
        {
            transform.position += direction * transform.right * speed * Time.deltaTime;

        }
        
    }

    public void OnMoveClick()
    {
        allowMovement = true;
        
    }

    public void OnStopClick()
    {
        allowMovement = false;
    }

    public void OnFlipClick()
    {
        direction *= -1f;
    }
}
