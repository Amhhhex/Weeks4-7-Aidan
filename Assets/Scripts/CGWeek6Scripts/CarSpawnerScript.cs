using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerScript : MonoBehaviour
{

    public GameObject car;

    public List<GameObject> cars = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 currentRotation = transform.eulerAngles;

        currentRotation.z = 270;


        for(int i = 0; i < 5; i++)
        {
            Vector2 randomY = Random.insideUnitCircle * 3;



            GameObject tempCar = Instantiate(car);

            Vector2 position = tempCar.transform.position;

            position.y = randomY.y;

            tempCar.transform.position = position;

            cars.Add(tempCar);
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
