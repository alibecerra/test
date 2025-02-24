using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Fireball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10f;
    public int damage = 1;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();

        if(player != null){
            player.Hurt(damage);
        }

        Destroy(this.gameObject);
    }

    void Update()
    {
       transform.Translate(0,0,speed * Time.deltaTime);
    }
}
