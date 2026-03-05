using UnityEngine;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
public class MoreseCodeTranslator : MonoBehaviour
{
    public AudioSource dialogueSOund;
    public AudioClip dot;
    public AudioClip dash;
    Queue<AudioClip> message = new Queue<AudioClip>();
    public float delay = .2f;
    float timer;
    private Dictionary<char, string> morseCodeDict = new Dictionary<char, string>() { 
        {'a', ".-" }, {'b', "-..." }, { 'c', "-.-."}, { 'd', "-.."}, { 'e', "."}, { 'f', "..-."}, { 'g', "--."}, { 'h', "..."}, { 'i', ".."},
        { 'j', ".---"}, { 'k', "-.-"}, { 'l', ".-.."}, { 'm', "--"}, {'n', "-."}, { 'o', "---"}, { 'p', ".--."}, {'q', "--.-"}, {'r', ".-."},
        { 's', "..."}, {'t', "-"}, {'u', "..-"}, {'v', "...-"}, { 'w', ".--"}, {'x', "-..-"}, { 'y', "-.--"}, {'z', "--.."},
        { '0', "-----"}, { '1', ".----"}, { '2', "..---"}, {'3', "...--"}, { '4', "....-"}, { '5', "....."}, {'6', "-...."}, { '7', "--..."}, 
        {'8', "---.."}, { '9', "----."}, {'?', "..--.."}, { '.', ".-.-.-"}, { ',', "--..--"}, {'"', ".-..-."}, { ' ', "/"}
    };
    private void Start()
    {
        string testText = translate("The quick brown fox jumped over the hole");
        Debug.Log("Morse Code test: " + testText);
        morseCodeToSound(testText);
    }
    public string translate(string text)
    {
        string morseCode = "";
        text = text.ToLower();
        foreach (char c in text)
        {
            morseCode += morseCodeDict[c] + " ";
        }
        return morseCode;
    }
    public void morseCodeToSound(string morse)
    {
        foreach (char c in morse)
        {
            if (c == '.')
            {
                message.Enqueue(dot);
            }
            else if(c == '/')
            {
                //code in silence and wait
            }
            else
            {
                message.Enqueue(dash);
            }
        }
    }
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (!dialogueSOund.isPlaying && message.Count > 0 && timer <= 0)
        {
            AudioClip next = message.Dequeue();
            dialogueSOund.clip = next;
            dialogueSOund.Play();
            timer = delay;
        }
    }
}
