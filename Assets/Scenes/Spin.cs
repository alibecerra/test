using UnityEngine;

public class Spin : MonoBehaviour 
{

    public float speed = 3.0f;
    void Start ()
    {

    }

    void Update () 
    {
        transform.Rotate(0, speed, 0);
    }

}
