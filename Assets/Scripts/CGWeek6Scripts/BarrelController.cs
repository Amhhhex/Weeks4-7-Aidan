using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelController : MonoBehaviour
{

    public GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {

        

        Vector3 currentMousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        currentMousePosition.z = 0;
        

        //float currentRotationV2 = Vector3.Angle(transform.position, currentMousePosition);

        //currentRotation.z = currentRotationV2;

        Vector3 temp = transform.right = currentMousePosition - transform.position;

        //transform.right = temp;

        transform.eulerAngles += transform.right * 1f * Time.deltaTime;

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
       
        

        //currentRotation.x = 0;
        //currentRotation.y = 0;
        
        //transform.eulerAngles = currentRotation;
    }
}
