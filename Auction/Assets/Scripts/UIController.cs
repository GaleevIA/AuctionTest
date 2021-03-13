using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Класс для организации логики UI
public class UIController : MonoBehaviour
{
    [SerializeField]
    private Scrollbar _horizontalScrollbar;
    [SerializeField]
    private float _scrollSpeed;

    //Обработчик кнопки прокрутки влево
    public void OnButtonLeftClick()
    {
        _horizontalScrollbar.value -= Time.deltaTime * _scrollSpeed;
    }

    //Обработчик кнопки прокрутки вправо
    public void OnButtonRightClick()
    {
        _horizontalScrollbar.value += Time.deltaTime * _scrollSpeed;
    }
    //Обработчик кнопки закрытия окна
    public void OnButtonCloseClick()
    {
        this.gameObject.SetActive(false);
    }
}
