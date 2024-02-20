using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text dialogueText;
    public string[] dialogue;
    private int index;
    public int linesAmount;
    public float wordSpeed;

    private void Start()
    {
        StartCoroutine(Typing());    
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) NextLine();
        if (linesAmount == 2)
        {
        }
    }

    public void ZeroText()
    {
        dialogueText.text = "";
        index = 0;
        
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        linesAmount += 1;
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else ZeroText();
    }
}
