using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectablePlayer : MonoBehaviour
{
    static int score = 0;
    public TextMeshProUGUI scoreText;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coinPrefab"))
        {
            score += 1;
        }
    }


    void Start()
    {
        scoreText.text = "0";
    }


    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ClearScore()
    {
        score = 0;
    }
}
