using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider healthSlider;

    public SpriteRenderer player;

    public int health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //healthSlider.maxValue = 10;

        health = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if(player.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            healthSlider.value-= 1;
        }

        if(healthSlider.value == 0)
        {
            gameObject.SetActive(false);
        }
        
        //healthSlider.value = health;
    }


    public void heal()
    {
        healthSlider.value += 5;
    }
}
