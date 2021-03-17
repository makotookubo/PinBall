using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoresetting : MonoBehaviour
{
    private GameObject scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

        this.scoreText.GetComponent<Text>().text = "score:" + score;
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 10;
        }


        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 20;
        }
    }
}