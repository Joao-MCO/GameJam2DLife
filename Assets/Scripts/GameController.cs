using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Pontuacao
    private int score;
    public static GameController instance;
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score = 0;
        scoreText.text = "0000";
    }

    public void Scored(int pont){
        score += pont;
        if(score>1000)
            scoreText.text = score.ToString();
        else if(score>100)
            scoreText.text = "0" + score.ToString();
        else
            scoreText.text = "00" + score.ToString();
    }

    private void Update() {

    }
}
