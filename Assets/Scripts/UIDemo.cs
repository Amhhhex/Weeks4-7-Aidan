using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{

    SpriteRenderer sr; //the square in the world

    public Image duckieImage; //the duckie IMAGE on the UI canvas

    public int howManyClicks = 0;

    public TextMeshProUGUI firstText;

    public Slider slider;

    public TextMeshProUGUI sliderValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        firstText.text = howManyClicks.ToString();

        slider.wholeNumbers = true;

        slider.value = 2;
    }

    // Update is called once per frame
    void Update()
    {

        sliderValue.text = slider.value.ToString();

        if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
            ChangeColour();
            addNumber();
           
        }
        
    }



    public void ChangeColour()
    {
        sr.color = Random.ColorHSV();
        duckieImage.color = sr.color;
    }

    public void SetScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void addNumber()
    {
        howManyClicks++;
        firstText.text = howManyClicks.ToString();
    }
}
