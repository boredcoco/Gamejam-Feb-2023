using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 10;

    public Slider healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.value(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth -= 1 * Time.deltaTime;
        healthBar.value(currentHealth);
    }
}
