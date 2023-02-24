using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{

    Collision myCollision;
    private GameObject scoreText;
    int value = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            value += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            value += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            value += 30;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            value += 40;
        }
        this.scoreText.GetComponent<Text>().text = "Score=" + value;

    }
}
