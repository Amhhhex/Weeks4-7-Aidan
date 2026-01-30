using UnityEngine;

public class PowerSwitch : MonoBehaviour
{


    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.rotation.z += transform.eulerAngles * speed;
        
    }


    public void StartSpin()
    {
        speed = 100f;

    }

    public void StopSpin()
    {
        speed = 0f;
    }
}
