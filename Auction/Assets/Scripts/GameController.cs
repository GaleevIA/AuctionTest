using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

//Класс для управления загрузкой и отображением данных
public class GameController : MonoBehaviour
{
    [SerializeField]
    private Connector _www;
    [SerializeField]
    private RectTransform _prefab;
    [SerializeField]
    private RectTransform _content;

    void Start()
    {
        //Подпишемся на события получения данных с сервера и вызовем процедуру обращения к серверу
        _www.OnDataRecieved += OnModelsRecieve;
        _www.UpdateItems();       
    }

    //Метод обрабатывает полученные данные с сервера
    void OnModelsRecieve(ItemModel[] models)
    {
        foreach (var model in models)
        {
            var instance = GameObject.Instantiate(_prefab.gameObject) as GameObject;
            instance.transform.SetParent(_content, false);
            InitializeItemView(instance, model);
        }
    }

    //Метод создает экземпляр ячейки для отображения на экране данных
    void InitializeItemView(GameObject viewGameObject, ItemModel model)
    {
        ItemView view = viewGameObject.GetComponent<ItemView>();
        view.itemName.text = model.itemName;
        view.itemCount.text = $"x{model.itemCount}";
        view.itemPrice.text = Convert.ToString(model.itemPrice);
        view.playerName.text = model.playerName;       
        
        LoadAsset<Sprite>(model.itemImg, view, "itemImg");
        LoadAsset<Sprite>(model.playerImg, view, "playerImg");
    }

    //Метод выполняет асинхронную загрузку изображений из Addressable
    public AsyncOperationHandle<T> LoadAsset<T>(string assetName, ItemView view, string fieldName)
    {
        Debug.Log("Loading asset: " + assetName);

        AsyncOperationHandle<T> asyncOperationHandle = Addressables.LoadAssetAsync<T>(assetName);
        asyncOperationHandle.Completed += (operHandle) => { AsyncOperationHandle_Completed(assetName, operHandle, view, fieldName); };
        return asyncOperationHandle;
    }

    //Метод считывает ответ при асинхроннной загрузке изображения и заполняет соответствующее поле
    private void AsyncOperationHandle_Completed(string assetName, AsyncOperationHandle operHandle, ItemView view, string fieldName)
    {
        Debug.Log("Loading asset complete(" + operHandle.Status + "): " + assetName);

        if (operHandle.Status == AsyncOperationStatus.Failed && operHandle.OperationException != null)
        {
            if (operHandle.OperationException is System.IO.IOException)
            {
                Debug.LogError(operHandle.OperationException.Message);
            }
        }
        else
        {
            switch (fieldName)
            {
                case "itemImg":
                    {
                        view.itemImg.sprite = (Sprite)operHandle.Result;
                        break;
                    }
                case "playerImg":
                    {
                        view.playerImg.sprite = (Sprite)operHandle.Result;
                        break;
                    }
            }
            
        }
    }
}

