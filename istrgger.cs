using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class istrgger : MonoBehaviour
{
    public int score = 0;
    [SerializeField] public Text text_score;
    [SerializeField] public Text text_record;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "win")
        {
            score++;
            text_score.text = "score: " + score.ToString();
        }
    }
    void Update()
    {

        if (PlayerPrefs.GetInt("score") < score)
        {
            text_record.text = "record: " + score;
            PlayerPrefs.SetInt("score", score);
        }
        else if(PlayerPrefs.GetInt("score") > score)
        {
            try
            {
                text_record.text = "record: " + PlayerPrefs.GetInt("score").ToString();
            }
            catch
            {
                
            }
        }
        if (Input.GetKey("l"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
    }

}
