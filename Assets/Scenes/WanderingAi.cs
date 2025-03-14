using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class WanderingAi : MonoBehaviour{

    [SerializeField] GameObject fireballPrefab;
    private GameObject fireball;


    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    private bool isAlive;

    public const float _baseSpeed = 3f;

    private void OnEnable()
    {
        Messenger<float>.AddListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);       
    }
    private void OnDisable()
    {
        Messenger<float>.RemoveListener(GameEvent.SPEED_CHANGED, OnSpeedChanged);
    }
    private void OnSpeedChanged(float value){
        speed = _baseSpeed * value;
    }

    

    private void Start(){
        isAlive = true;
    }

    public void SetAlive(bool alive){
        isAlive = alive;
    }

    void Update(){

        if (isAlive){
            transform.Translate(0,0, speed * Time.deltaTime);
        }
        transform.Translate(0,0,speed * Time.deltaTime);

        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        if(Physics.SphereCast(ray, 0.75f, out hit)){

            GameObject hitObject = hit.transform.gameObject;

            if (hitObject.GetComponent<PlayerCharacter>()){
                if (fireball == null){
                    fireball = Instantiate(fireballPrefab) as GameObject;
                    fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    fireball.transform.rotation = transform.rotation;
                }
            } else if(hit.distance < obstacleRange){
                float angle = Random.Range(-110, 110);
                transform.Rotate(0,angle,0);
            }
        }
    }
}