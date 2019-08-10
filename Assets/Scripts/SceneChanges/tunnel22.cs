using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tunnel22 : MonoBehaviour
{
    public GameObject carrot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && carrot.activeInHierarchy == true)
        {
            SceneManager.LoadScene(6);
        }
        else if (collision.gameObject.tag == "Player" && carrot.activeInHierarchy == false)
        {
            SceneManager.LoadScene(5);
        }
    }
}

