using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaltPepperDialogue : MonoBehaviour
{
    public GameObject Salt;
    public GameObject Pepper;

    public GameObject TextBox;

    public GameObject ChoiceWhat;
    public GameObject ChoiceOk;

    public GameObject ChoiceDontCare;
    public GameObject ChoiceSalt;
    public GameObject ChoicePepper;

    public GameObject ChoiceBye;

    public int ChoiceMade;

    public void ChoiceOptionWhat()
    {
        TextBox.GetComponent<Text>().text = "S: Pepper keeps saying that [Bla, Bla, Bla], but I think that [Bla, Bla, Bla].";
        ChoiceMade = 1;

        ChoiceWhat.SetActive(false);
        ChoiceOk.SetActive(true);
    }

    public void ChoiceOptionOk()
    {
        TextBox.GetComponent<Text>().text = "P: What do YOU think, Snowflake?!";
        ChoiceMade = 2;

        ChoiceOk.SetActive(false);

        ChoiceDontCare.SetActive(true);
        ChoiceSalt.SetActive(true);
        ChoicePepper.SetActive(true);
    }

    public void ChoiceOptionDontCare()
    {
        TextBox.GetComponent<Text>().text = "S: What?! But you HAVE to care!";
        ChoiceMade = 3;

        ChoiceDontCare.SetActive(true);
        ChoiceSalt.SetActive(true);
        ChoicePepper.SetActive(true);
    }

    public void ChoiceOptionSalt()
    {
        TextBox.GetComponent<Text>().text = "P: Hmph! Snowflake, you don't have to pretend to be on Salt's side! Just be honest; who do you agree with?";
        ChoiceMade = 4;

        ChoiceDontCare.SetActive(true);
        ChoiceSalt.SetActive(true);
        ChoicePepper.SetActive(true);
    }

    public void ChoiceOptionPepper()
    {
        TextBox.GetComponent<Text>().text = "S: Aw, really? Well, alright, I guess...";
        ChoiceMade = 5;

        ChoiceDontCare.SetActive(false);
        ChoiceSalt.SetActive(false);
        ChoicePepper.SetActive(false);

        ChoiceBye.SetActive(true);
    }

    public void ChoiceOptionBye()
    {
        TextBox.SetActive(false);
        ChoiceMade = 6;

        ChoiceBye.SetActive(false);
        Salt.SetActive(false);
        Pepper.SetActive(false);
    }
}