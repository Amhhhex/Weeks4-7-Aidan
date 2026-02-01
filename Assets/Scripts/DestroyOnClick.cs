using UnityEngine;
using UnityEngine.InputSystem;


public class DestroyOnClickl : MonoBehaviour
{

    public new GameObject gameObject;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        


        if (Mouse.current.rightButton.wasPressedThisFrame) {
            
            SpriteRenderer spirte = gameObject.GetComponent<SpriteRenderer>();
            if (spirte.bounds.Contains(mousePosition))
            {
                print("okay");
                Destroy(gameObject);
            }
        }
    }
}
