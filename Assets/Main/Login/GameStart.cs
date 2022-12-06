using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button _startButton = GameObject.Find("Button_start").GetComponent<Button>();
        Button _signupButton = GameObject.Find("Button_signup").GetComponent<Button>();
        Button _parentsButton = GameObject.Find("Button_parents").GetComponent<Button>();
        Button _starButton = GameObject.Find("Button_star").GetComponent<Button>();
        
        _startButton.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            transform.parent.transform.Find("背景").gameObject.SetActive(true);
            transform.parent.transform.Find("登录窗口").gameObject.SetActive(true);
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
