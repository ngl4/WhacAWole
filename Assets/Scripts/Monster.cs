using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Monster : MonoBehaviour, IPointerClickHandler
{
    //float decimals 
    //interger no decimals
    public float liveTime;
    private MonsterController monsterController; //reference to the MonsterCotroller script
    private ScoreKeeper scoreKeeper;
    public int pointValue;

    void Awake() //the moment the monster is instatiated 
    {
        monsterController = FindObjectOfType<MonsterController>();  //use the variable to represent the script MonsterController 
        scoreKeeper = FindObjectOfType<ScoreKeeper>(); //Script is in elsewhere and on another object  //GetComponent can only be used in the same GameObject 
    }

    // Start is called before the first frame update
    void Start() 
    {
        liveTime = Random.Range(monsterController.minLiveTime, monsterController.maxLiveTime);
        StartCoroutine(Sleep());
    }

    public IEnumerator Sleep() //when you want something to happen after a certain amount of time, you have to use IEnumerator 
    {
        yield return new WaitForSeconds(liveTime); //always contain WaitforSeconds and you can just change the parameter
        Destroy(gameObject);
    }

    public void OnPointerClick(PointerEventData pointerEventData)   //if it is pointed on, it will ... 
    {
        scoreKeeper.AddScore(pointValue);
        Destroy(gameObject);
    }
}
