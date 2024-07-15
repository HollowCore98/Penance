using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager dialogueManager;

    [Header("UI")]
    [SerializeField]
    private GameObject dialoguePanel;

    [SerializeField]
    private TextMeshProUGUI dialogueText;

    private Story currentStory;

    private bool dialogueIsPlaying;
    

    void Awake()
    {
        dialogueManager = this;

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
    }

    void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }
    }

    public static DialogueManager GetDialogueManager()
    {
        return dialogueManager;
    }

    public void EnterReadMode(TextAsset inkJson)
    {
        currentStory = new Story(inkJson.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
    }

    public void ExitReadMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    public void ContinueStory()
    {
        if (currentStory.canContinue == true)
        {
            dialogueText.text = currentStory.Continue();
            
        }
        else
        {
            ExitReadMode();    
        }
    }
}
