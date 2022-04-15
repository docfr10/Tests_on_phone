using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public TextAsset All;
    public string Text;
    public string Task;
    public string Answers;
    public string True_answer;

    public Text Tesk;
    public Text answer_1;
    public Text answer_2;
    public Text answer_3;

    // Start is called before the first frame update
    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        Task = s[0];
        Answers = s[1];
        True_answer = s[2];
        Tesk.text = Task;
        string[] A = Answers.Split(';');
        answer_1.text = A[0];
        answer_2.text = A[1];
        answer_3.text = A[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
