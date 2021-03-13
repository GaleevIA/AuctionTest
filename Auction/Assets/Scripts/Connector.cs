using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.AddressableAssets;

//Класс для взаимодействия с сервером
public class Connector : MonoBehaviour
{
    public Action<ItemModel[]> OnDataRecieved;

    //Метод выполняет обращение к серверу
    public void UpdateItems()
    {
        //string url = "http://localhost:3000/";
        //WWW www = new WWW(url);
        //StartCoroutine(GetItems(www, results => OnDataRecieved.Invoke(results)));
        Database database = new Database();
        OnDataRecieved.Invoke(database.items);
    }

    //Метод преобразовывает полученные данные с сервера в массив объектов ItemModel
    IEnumerator GetItems(WWW www, Action<ItemModel[]> callback)
    {
        yield return www;

        if (www.error == null)
        {
            ItemModel[] mList = JsonHelper.getJsonArray<ItemModel>(www.text);
            Debug.Log("WWW Success: " + www.text);
            callback(mList);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
}