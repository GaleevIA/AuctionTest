using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ласс дл€ преобразовани€ данных, полученных с сервера
public class JsonHelper
{
    //ћетод преобразовывает строку json, в массив данных
    public static T[] getJsonArray<T>(string json)
    {
        string newJson = "{ \"array\": " + json + "}";
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
        return wrapper.array;
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] array;
    }
}
