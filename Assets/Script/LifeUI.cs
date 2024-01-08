using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUI : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Life: " + GameObject.Find("Player").GetComponent<PlayerHealth>().health;
    }
}
