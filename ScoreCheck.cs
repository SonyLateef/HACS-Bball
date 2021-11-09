using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScoreCheck : MonoBehaviour
{
    public GameObject ball;
    public Canvas scoreText;
    private int score = 0;
    public TextMeshProUGUI tmp;


    void Start()
    {
        tmp.text = "count : ";
    }

    void OnTriggerEnter(Collider collision)
    {
       //tmp = scoreText.GetComponent<TextMeshProUGUI>();
        if (collision.transform.name == "Ball")
        {
            score++;
            Debug.Log(score);
            tmp.text = "count : " + score;
        }

    }
}
