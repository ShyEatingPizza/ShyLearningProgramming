using System;

//--------------------------------------------------------------------------------

public class Health {

    //--------------------------------------------------------------------------------
    // Fields
    //--------------------------------------------------------------------------------

    private string name;

    private float maxHealth;
    private float currentHealth;

    //--------------------------------------------------------------------------------
    // Constructor
    //--------------------------------------------------------------------------------

    public Health(string name, float maxHealth) {

        this.name = name;
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
    }

    //--------------------------------------------------------------------------------
    // Methods
    //--------------------------------------------------------------------------------

    public float GetMaxHealth() {
        return this.maxHealth;
    }

    public float GetCurrentHealth() {
        return this.currentHealth;
    }

    public void ApplyDamage(float damage) {

        this.currentHealth -= damage;

        if (this.currentHealth < 0) {
            this.currentHealth = 0;
        }
    }

    public void Print() {
        Console.WriteLine(this.name + " - Health: " + this.currentHealth + "/" + this.maxHealth);
    }
}