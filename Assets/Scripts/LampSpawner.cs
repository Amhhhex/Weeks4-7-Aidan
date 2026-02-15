using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    //The public variable for spawning the lamp prefab
    public GameObject lamp;

    //An empty gameObject that will store the lamp object
    GameObject clone;

    //A slider variable
    Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Instantiating the lamp object and storing the spawned object within clone
        clone = Instantiate(lamp, new Vector2(-6f, 3.5f), Quaternion.identity);

        //retriving the slider object component from the battery health slider
        slider = GetComponent<Slider>();

        
    }

    // Update is called once per frame
    void Update()
    {

        //Once the slider reaches it's minimum value (0)
        if(slider.value == 0)
        {
            //Destroy the lamp preFab
            Destroy(clone);
        }
        
    }
}
