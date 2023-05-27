using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Transform snake;
    public Text scoreText;
    public GameObject food;
    public GameObject segment;
    public float offset = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        spawnFood();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int increase)
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void spawnFood()
    {
        Instantiate(food, new Vector3(Random.Range(-20, 20), Random.Range(-2, 10), Random.Range(-11, 20)), Quaternion.identity); ;
    }

    public void spawnSegment()
    {
        Instantiate(segment, snake.transform.position - snake.transform.forward * offset, Quaternion.identity, snake);
        offset += 1.5f;
    }
}
