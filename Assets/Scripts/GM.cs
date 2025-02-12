using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

    public bool defeat = false;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI scoreFinal;
    private int score;

    [SerializeField]
    private GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        UpdateScore(0);
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (defeat==true)
        {
            scoreFinal.text = "Score: " + score;
            gameOver.SetActive(true);
        }
        
    }

    

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

}
