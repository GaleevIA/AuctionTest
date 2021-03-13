using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//����� ��� ����������� ������ UI
public class UIController : MonoBehaviour
{
    [SerializeField]
    private Scrollbar _horizontalScrollbar;
    [SerializeField]
    private float _scrollSpeed;

    //���������� ������ ��������� �����
    public void OnButtonLeftClick()
    {
        _horizontalScrollbar.value -= Time.deltaTime * _scrollSpeed;
    }

    //���������� ������ ��������� ������
    public void OnButtonRightClick()
    {
        _horizontalScrollbar.value += Time.deltaTime * _scrollSpeed;
    }
    //���������� ������ �������� ����
    public void OnButtonCloseClick()
    {
        this.gameObject.SetActive(false);
    }
}
