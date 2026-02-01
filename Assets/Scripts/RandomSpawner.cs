using UnityEngine;
using UnityEngine.InputSystem;

public class RandomSpawner : MonoBehaviour
{

    public GameObject randomObject;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {

            Vector2 mousePosition = Mouse.current.position.ReadValue();

            SpriteRenderer spirte = gameObject.GetComponent<SpriteRenderer>();

            if (spirte.bounds.Contains(mousePosition))
            {
                print("okay");
                Destroy(gameObject);
            }
        }


    }

    public void Spawner()
    {

        Instantiate(randomObject);

        randomObject.transform.position = new Vector2(Random.insideUnitCircle.x * 3f, Random.insideUnitCircle.y * 3f);

    }



}




