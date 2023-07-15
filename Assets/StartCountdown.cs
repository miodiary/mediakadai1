using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCountdown : MonoBehaviour
{
    float countdown = 3.0f;
    Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown>0)
        {
            countdown -= Time.deltaTime;
            int n = (int)countdown;
            uiText = GetComponent<Text>();
            uiText.text = n.ToString();
        }else
        {
            uiText = GetComponent<Text>();
            uiText.text = "";
        }
    }
}
