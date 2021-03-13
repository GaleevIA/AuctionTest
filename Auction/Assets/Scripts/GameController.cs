using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

//����� ��� ���������� ��������� � ������������ ������
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
        //���������� �� ������� ��������� ������ � ������� � ������� ��������� ��������� � �������
        _www.OnDataRecieved += OnModelsRecieve;
        _www.UpdateItems();       
    }

    //����� ������������ ���������� ������ � �������
    void OnModelsRecieve(ItemModel[] models)
    {
        foreach (var model in models)
        {
            var instance = GameObject.Instantiate(_prefab.gameObject) as GameObject;
            instance.transform.SetParent(_content, false);
            InitializeItemView(instance, model);
        }
    }

    //����� ������� ��������� ������ ��� ����������� �� ������ ������
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

    //����� ��������� ����������� �������� ����������� �� Addressable
    public AsyncOperationHandle<T> LoadAsset<T>(string assetName, ItemView view, string fieldName)
    {
        Debug.Log("Loading asset: " + assetName);

        AsyncOperationHandle<T> asyncOperationHandle = Addressables.LoadAssetAsync<T>(assetName);
        asyncOperationHandle.Completed += (operHandle) => { AsyncOperationHandle_Completed(assetName, operHandle, view, fieldName); };
        return asyncOperationHandle;
    }

    //����� ��������� ����� ��� ������������ �������� ����������� � ��������� ��������������� ����
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

