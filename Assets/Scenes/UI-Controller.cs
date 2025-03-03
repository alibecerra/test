using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] TMP_Text scoreLabel;
    [SerializeField] SettingsPopup settingsPopup;

    private int _score;

    private void OnEnable()
    {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void Osable()
    {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);   
    }

    private void OnEnemyHit(){
        _score += 1; 
        scoreLabel.text = _score.ToString();

    }
    private void Start()
    {
        _score = 0;
        scoreLabel.text = _score.ToString();
        settingsPopup.Close();
    }

    // Update is called once per frame
    void Update()
    {
        //scoreLabel.text = Time.realtimeSinceStartup.ToString();

    }

    public void OnOpenSettings(){
        //Debug.Log("Opening settings...");
        settingsPopup.Open();
    }
}
