using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FUNCTIONS : MonoBehaviour
{
    public string s = "Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.";
    public List<string> words;

    void threeAndSeven()
    {
        string temp;
        for(int i = 0; i < 1000; i++)
        {
            temp = i.ToString();
            if(temp.Contains("3") && temp.Contains("7"))
            {
                Debug.Log(temp);
            }
        }
    }
    void commonLetter()
    {
        s = s.ToLower();

        char winn = s[0];
        char current = s[0];
        char newn;
        int winnCount = 1;
        int currentCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            
            current = s[i];
            currentCount = 0;
            for (int j = 0; j < s.Length; j++)
            {
                newn = s[j];
                if (current == newn)
                {
                    currentCount++;
                }
            }
            if (Char.IsWhiteSpace(current))
            {

            } else if (currentCount > winnCount)
            {
                winn = current;
                winnCount = currentCount;
            }
            
        }
        Debug.Log(winn + " - " + winnCount);
    }
    List<string> listLetters(List<string> input)
    {
        List<string> uniques = new List<string>();

        foreach(string s in input)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (!uniques.Contains(Char.ToString(s[i])))
                {
                    uniques.Add(Char.ToString(s[i]));
                } 
            }
            
        }

        return uniques;
    }

    // Start is called before the first frame update e
    void Start()
    {
        threeAndSeven();
        commonLetter();
        string result = "";
        foreach (var item in listLetters(words))
        {
            result += item.ToString() + ", ";
        }
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
