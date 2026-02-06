using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider healthSlider;

    public SpriteRenderer player;

    public int health;

    public AudioSource AudioSource;

    public AudioClip chomp;

    public AudioClip death;

    //AudioSource.Play() plays the current clip in audioSource.clip and stops/restarts it
    //AudioSource.PlayOneShot(MyClip) plays MyClip and will play on top of a currently playing (on this Audio Source) clip

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

            AudioSource.clip = chomp;

            AudioSource.Play();
        }

        if(healthSlider.value == 0)
        {
            AudioSource.clip = death;
            AudioSource.Play();
            gameObject.SetActive(false);
        }
        
        //healthSlider.value = health;
    }


    public void heal()
    {
        gameObject.SetActive(true);
        healthSlider.value += 5;
    }
}
