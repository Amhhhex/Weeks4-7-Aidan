using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject lamp;

    GameObject clone;

    Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Vector3 objectPosition = transform.position;

        objectPosition.y += 10;

        transform.position = objectPosition;

        clone = Instantiate(lamp, new Vector2(-6f, 3.5f), Quaternion.identity);

        slider = GetComponent<Slider>();

        
    }

    // Update is called once per frame
    void Update()
    {

        if(slider.value == 0)
        {
            Destroy(clone);
        }
        
    }
}
