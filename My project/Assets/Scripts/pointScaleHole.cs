using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointScaleHole : MonoBehaviour
{

    public static float currentPoints;
    public static float totalPoints;
    bool grow;
    public Text scoreText;

    void Awake()
    {
        currentPoints = 0;
        totalPoints = 0;
        grow = false;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + totalPoints;
        //Debug.Log(totalPoints);
        if (currentPoints >= 0)
        {
            grow = true;
            currentPoints = currentPoints - 10 * Time.deltaTime;
        }

        if (currentPoints <= 0)
        {
            currentPoints = 0;
            grow = false ;
        }

        if (grow == true) 
        {
            this.gameObject.transform.localScale += new Vector3(0.001f, 0, 0.001f);
        }
    }
}
