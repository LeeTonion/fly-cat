using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TUONG : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoretext;

    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("gioihan"))
    {
        score++;
        scoretext.SetText(score.ToString());
        Destroy(gameObject);
    }
}
    void Start()
    {
        scoretext.SetText(score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


