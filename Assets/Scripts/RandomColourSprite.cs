using UnityEngine;
using UnityEngine.UI;

public class RandomColourSprite : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    public Slider rotationSlider;

    public AudioSource buttonSound;
    public AudioSource sliderSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;

        float rotationValue = rotationSlider.value;

        rotationValue *= 360;

        currentRotation.z = rotationValue;

        if (rotationSlider.value == rotationSlider.maxValue / 2)
        {
            sliderSound.Play();
        }

        transform.eulerAngles = currentRotation;
        
    }

    
    public void ChangeColour()
    {
        buttonSound.Play();
        spriteRenderer.color = Random.ColorHSV();
    }

}
