using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDisplay : MonoBehaviour
{
    public GameObject dialoguePannel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;
    public GameObject continueButton;
    public float wordSpeed;
    public bool playerIsClose;

    void Update()
    {
        if (playerIsClose)
        {
            if (dialoguePannel.activeInHierarchy)
            {
                ZeroText();
            }
            else
            {
                dialoguePannel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if (dialogueText.text == dialogue[index])
        {
            continueButton.SetActive(true);
        }
    }

    public void ZeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePannel.SetActive(false);

    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {

        continueButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            ZeroText();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<FirstPersonController>() != null)
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}


