using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServerOption : MonoBehaviour
{
    enum ServerType{Normal, Before, NoChat, FriendOnline}

    [SerializeField, Header("服务器选项")] private int _serverID = 1;
    [SerializeField] private string _serverName = "发明屋";
    [SerializeField] private ServerType _serverType = ServerType.Normal;
    [SerializeField,Range(1, 5)] private int _userCount = 1;

    [SerializeField, Header("GameObjects")] private Text _serverIDObj;
    [SerializeField] private Text _serverNameObj;
    [SerializeField] private Image _serverTypeObj;
    [SerializeField] private GameObject _serverIsFull;
    [SerializeField] private Image[] _userCountObj;
    
    [SerializeField, Header("素材")] private Sprite[] _serverTypeImg;
    [SerializeField] private Sprite _userCountImg;
    
    void Start()
    {
        _serverIDObj.text = _serverID.ToString();
        _serverNameObj.text = _serverName;
        _serverTypeObj.sprite = _serverTypeImg[(int)_serverType];
        if (_userCount >= 1) _userCountObj[0].sprite = _userCountImg;
        if (_userCount >= 2) _userCountObj[1].sprite = _userCountImg;
        if (_userCount >= 3) _userCountObj[2].sprite = _userCountImg;
        if (_userCount >= 4) _userCountObj[3].sprite = _userCountImg;
        if (_userCount >= 5)
        {
            _userCountObj[4].sprite = _userCountImg;
            _serverIsFull.SetActive(true);
        }
        
        GetComponent<Button>().onClick.AddListener(() =>
        {
            print("选择服务器：" + _serverID + "." + _serverName);
        });
    }
    
    

}
