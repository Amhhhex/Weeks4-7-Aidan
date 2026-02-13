using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpeed : MonoBehaviour
{
    

    float speed = 2f;

    Vector3 mousePosition;

    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        mousePosition.z = 0;

        transform.up = mousePosition - transform.position;
        
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        spriteRenderer.sortingOrder = -1;

        transform.position += transform.up * speed * Time.deltaTime;
        

        
    }
}
