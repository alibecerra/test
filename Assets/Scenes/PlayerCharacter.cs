using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health;
    void Start()
    {
       health = 5; 
    }

    // Update is called once per frame
    public void Hurt(int damage)
    {
       health -= damage;
       Debug.Log($"Health: {health}");
    }
}
