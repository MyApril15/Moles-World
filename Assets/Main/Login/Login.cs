using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField] private GameObject _loadingPrefab;
    
    GameObject _loadingObj;
    void Start()
    {
        Button _loginButton = GameObject.Find("Button_登录").GetComponent<Button>();
        Button _registerButton = GameObject.Find("Button_注册").GetComponent<Button>();
        
        _loginButton.onClick.AddListener(() =>
        {
            _loginButton.interactable = false;
            _loadingObj = Instantiate(_loadingPrefab);
            Invoke("FinishLoading", 3);
        });
        
    }

    void FinishLoading()
    {
        _loadingObj.GetComponent<LoadingIcon>().Finish();
        gameObject.SetActive(false);
        transform.parent.transform.Find("选择服务器").gameObject.SetActive(true);
    }
}
