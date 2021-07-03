using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour 
{
    public List<GameObject> monsters; //list usually put an S at the end //assign within the inspector 
    public Vector2 xrange; //min and max area of the game 
    public Vector2 zrange; //When Vector2 is declared in Start(), remember to use new
    public float spawnInterval; //how often it shows up?
    public float spawnProbability; //Will it show after that amount of time?
    public float maxLiveTime; //max amount of time a monster can live before it goes away
    public float minLiveTime; //min amount of time a monster can live before it goes away

    void Start()  
    {
        InvokeRepeating("SpawnMonster", spawnInterval, spawnInterval); //Run the Spawn Monster function every 1 sec
    }

    public void SpawnMonster()
    {
        float randomProbability = Random.Range(0.0f,1.0f);  
        if (randomProbability < spawnProbability)
        {
            int randomIndex = Random.Range(0, monsters.Count); //random index numbers for the monsters list
            float xValue = Random.Range(xrange.x, xrange.y);  //random position
            float zValue = Random.Range(zrange.x, zrange.y); // x and z means the position will be on the ground and not flying around
            Vector3 spawnPosition = new Vector3(xValue, 0f, zValue); //take the x and z and use them for the position of the monster
            GameObject monster = (GameObject)Instantiate(monsters[randomIndex], spawnPosition,Quaternion.identity); //instantiate(what?,Where?,Will it rotate?)
            //Quaternion.identity == keep its original identity and dont make any changes  //Quaternion means rotation ONLY

        }
    }


    void Update()
    {
        
    }
}
