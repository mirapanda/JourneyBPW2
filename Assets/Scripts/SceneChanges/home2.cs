using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home2 : MonoBehaviour
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

        if(pos <= -17)
        {
            enterText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(2);
            }
        }
        else
        {
            enterText.SetActive(false);
        }
    }
}

