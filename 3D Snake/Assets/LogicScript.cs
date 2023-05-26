using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        
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
        Instantiate(food, new Vector3(Random.Range(-20, 20), Random.Range(-2, 20), Random.Range(20, 20)), transform.rotation);
    }
}
