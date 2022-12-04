using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField, Header("UIOption")] private Sprite _iconImg;
    [SerializeField, Range(0, 100)] private int _processPercent = 0;
    [SerializeField] private string _noticeContext = "公告内容";
    [SerializeField] private string _loadingContext = "正在加载摩尔庄园";

    [SerializeField, Header("Objects")] private Image _iconImgObj;
    [SerializeField] private RectTransform _processPercentBar;
    [SerializeField] private Text _processPercentText;
    [SerializeField] private RectTransform[] _processPercentBarPivot;
    [SerializeField] private Text _noticeContextObj;
    [SerializeField] private Text _loadingContextText;
    
    void Start()
    {
        _iconImgObj.sprite = _iconImg;
        _noticeContextObj.text = _noticeContext;
        _loadingContextText.text = _loadingContext;

    }
    
    void Update()
    {
        SetPercent(100);
    }

    public void SetPercent(int process)
    {
        float num = _processPercentBarPivot[1].localPosition.x - _processPercentBarPivot[0].localPosition.x;
        num = num * _processPercent / 100;
        _processPercentBar.sizeDelta = new Vector2(num,0);
        _processPercentText.text = _processPercent.ToString() + "%";
    }
}
