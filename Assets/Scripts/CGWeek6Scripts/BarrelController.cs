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
        

        transform.right = currentMousePosition - transform.position;

       

        //transform.eulerAngles += transform.right * 1f * Time.deltaTime;

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
       
    }
}
