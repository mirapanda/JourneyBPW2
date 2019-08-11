using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Licorice1Dialogue : MonoBehaviour
{
    public GameObject Licorice;

    public GameObject TextBox;

    public GameObject ChoiceHi;

    public GameObject ChoiceSure;
    public GameObject ChoiceDontLike;

    public GameObject ChoiceThatsAll;

    public GameObject ChoiceOk;
    public GameObject ChoiceNoWay;
    public GameObject ChoiceNope;

    public GameObject ChoiceSeeYa;

    public int ChoiceMade;

    public void ChoiceOptionHi()
    {
        TextBox.GetComponent<Text>().text = "Hmm, that depends. Can you do me a favour?";
        ChoiceMade = 1;

        ChoiceHi.SetActive(false);

        ChoiceSure.SetActive(true);
        ChoiceDontLike.SetActive(true);
    }

    public void ChoiceOptionSure()
    {
        TextBox.GetComponent<Text>().text = "I knew I could count on you! Can you get me a carrot?";
        ChoiceMade = 2;

        ChoiceSure.SetActive(false);
        ChoiceDontLike.SetActive(false);

        ChoiceThatsAll.SetActive(true);
    }

    public void ChoiceOptionDontLike()
    {
        TextBox.GetComponent<Text>().text = "Ha, ha! You're funny. I just want a nice, juicy carrot!";
        ChoiceMade = 3;

        ChoiceSure.SetActive(false);
        ChoiceDontLike.SetActive(false);

        ChoiceThatsAll.SetActive(true);
    }

    public void ChoiceOptionThatsAll()
    {
        TextBox.GetComponent<Text>().text = "You know how Silver always hogs them! It's not fair, he has so many. Get me a carrot from Silver, won't you?";
        ChoiceMade = 4;

        ChoiceThatsAll.SetActive(false);

        ChoiceOk.SetActive(true);
        ChoiceNoWay.SetActive(true);
    }

    public void ChoiceOptionOk()
    {
        TextBox.GetComponent<Text>().text = "Yes! Thank you, Snowflake, you're the best!";
        ChoiceMade = 5;

        ChoiceOk.SetActive(false);
        ChoiceNoWay.SetActive(false);
        ChoiceNope.SetActive(false);

        ChoiceSeeYa.SetActive(true);
    }

    public void ChoiceOptionNoWay()
    {
        TextBox.GetComponent<Text>().text = "He won't let me! Please, Snowflake?";
        ChoiceMade = 6;

        ChoiceNoWay.SetActive(false);

        ChoiceNope.SetActive(true);
    }

    public void ChoiceOptionNope()
    {
        TextBox.GetComponent<Text>().text = "Fine, then, but I'm not moving.";
        ChoiceMade = 7;

        ChoiceOk.SetActive(false);
        ChoiceNope.SetActive(false);

        ChoiceSeeYa.SetActive(true);
    }

    public void ChoiceOptionSeeYa()
    {
        TextBox.SetActive(false);
        ChoiceMade = 8;

        ChoiceSeeYa.SetActive(false);
    }
}