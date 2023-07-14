using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalScore : MonoBehaviour
{
    public Text ScoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = ScoreCalc.getscore();

        ScoreText.text = string.Format($"Score:{score}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
