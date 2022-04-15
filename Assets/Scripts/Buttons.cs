using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject VPR;
    public Image button;
    public Text t;
    public Questions questions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()
    {
        if (t.text == questions.True_answer)
        {
            button.GetComponent<Image>().color = Color.green;
            StartCoroutine(Wait());
        }
        else
        {
            button.GetComponent<Image>().color = Color.red;
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        VPR.SetActive(false);
    }

}
