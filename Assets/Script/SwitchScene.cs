using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<EnemyHealth>().health <= 1)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
