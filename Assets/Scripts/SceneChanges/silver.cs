using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class silver : MonoBehaviour
{
    float pos;
    public GameObject enterText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position.x;

        if (pos <= -0.5 && pos >= -9.5)
        {
            enterText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(10);
            }
        }
        else
        {
            enterText.SetActive(false);
        }
    }
}

