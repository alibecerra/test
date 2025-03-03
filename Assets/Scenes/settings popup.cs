using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SettingsPopup : MonoBehaviour{

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close(){
        gameObject.SetActive(false);
    }

    public void OnSubmitName(string name){
        Debug.Log(name);
    }

    public void OnSpeedValue(float speed){
          Debug.Log($"Speed: {speed}");
          Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
    }
}