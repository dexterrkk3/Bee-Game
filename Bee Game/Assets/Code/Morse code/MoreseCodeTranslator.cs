using UnityEngine;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
public class MoreseCodeTranslator : MonoBehaviour
{
    public AudioSource dot;
    public AudioSource dash; 
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
        float timeDelay = 0.0f; 
        foreach (char c in morse)
        {
            timeDelay += Time.deltaTime;
            if (c == '.')
            {
                dot.PlayDelayed(timeDelay);
            }
            else
            {
                dash.PlayDelayed(timeDelay);
            }
        }
    }
}
