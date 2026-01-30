using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawningPrefab;

    public Color pacerColour;

    private float waitProgress;

    public float destroyDuration;

    private float destroyProgress;

    public float waitDuration;

    public float pacerSpeed;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {




        Vector3 originPositon = Vector3.zero;

        //When instantiating an object at a specific position you will need to pass a rotation value as an arguement
        //But if you want to spawn an object that has a rotation independent from that GameObjects rotation value then you will need to pass it a different value
        //You could create a brand new Vector3 variable with 0 values like so, Vector3 zero = Vector3.zero
        //Or you can pass the following line
        //Quaternion.identity which will pass a Quaternion value equal to 0,0,0
        //Instantiate(spawningPrefab, transform.position, Quaternion.identity);
        
        //Instantiate(spawningPrefab);


        waitDuration = 3f;



        
    }

    // Update is called once per frame
    void Update()
    {

        waitProgress += Time.deltaTime;


        if (waitProgress >= waitDuration) 
        {

            //When Instantiate is called it actually returns a GameObject variable
            //If you want to destroy that specific object, you will need to store that object into a variable
            //Then within Destroy, call that variable
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableObject.GetComponent<TypeOfComponent>();
            Pacer tempPacer = spawnedObject.GetComponent<Pacer>();
            SpriteRenderer colour = spawnedObject.GetComponent<SpriteRenderer>();
            
            //Set the values of the spawned object, specifically its speed value and its colour
            tempPacer.speed = pacerSpeed;
            colour.color = pacerColour;

            Destroy(spawnedObject, destroyDuration);


            waitProgress = 0;
        }


        







    }

    public void IncreasePacerSpeed()
    {
        pacerSpeed++;
    }
}
