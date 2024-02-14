using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPouch : MonoBehaviour
{
    public int arrowCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (arrowCount <= 0)
        {
            Debug.Log("Out of arrows!");
        }
    }

    public void IncreaseArrowCount(int amount)
    {
        arrowCount += amount;
    }
}
