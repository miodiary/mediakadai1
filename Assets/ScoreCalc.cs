using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalc : MonoBehaviour
{
    public Text Scoretext;
    public static int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        string objectname = collision.gameObject.name;

        if (objectname == "BlueBallPrefab(Clone)")
        {
            score += 10;
            Scoretext.text = string.Format($"Score:{score}");
            Destroy(collision.gameObject);
        }
        else if (objectname == "RedBallPrefab(Clone)")
        {
            score += 20;
            Scoretext.text = string.Format($"Score:{score}");
            Destroy(collision.gameObject);
        }
    }

    public static int getscore()
    {
        return score;
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
