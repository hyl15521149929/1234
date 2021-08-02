using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    public Text Score;
    public Text HighScore;
    // Start is called before the first frame update
    void Start()
    {
        //HighScore.Text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void RollDic()
    {
        int number = Random.Range(1, 7);
        Score.text = number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            HighScore.text = number.ToString();
        }
    } 
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighScore.text = "0";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
