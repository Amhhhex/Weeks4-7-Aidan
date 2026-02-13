using UnityEngine;

public class Assignment2SpawnerCode : MonoBehaviour
{
    public GameObject artPiece;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(artPiece, transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
