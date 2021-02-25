using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayerText : MonoBehaviour
{
    public LifePlayer life;
    void Update()
    {
        Text textLife = this.GetComponent<Text>();
        textLife.text = life.life.ToString();
    }
}
