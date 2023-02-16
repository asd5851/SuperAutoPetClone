using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_TurnEndBtn : MonoBehaviour
{
    S_ObjectManager objectManager = default;
    List<GameObject> battleAnimalList_ = default;
    
    BattleTileObject battleTileObject = default;
    Object obj = default;
    GameObject battleTile = default;
    void Start()
    {
        battleTile = GameObject.Find("BattleTile");
        
    }
    //! 버튼을 누른순간 데이터를 저장해서 JSON으로 넘긴다.
    public void LoadBattleScene()
    {
        
        battleTileObject = GameObject.Find("ObjectManager").GetComponent<BattleTileObject>();
        objectManager = GameObject.Find("ObjectManager").GetComponent<S_ObjectManager>();
        objectManager.SearchBattleAnimal(battleTile);
        Debug.Log($"{battleTileObject}");
        battleAnimalList_ = objectManager.battleAnimalList;
        
        foreach(object obj in battleAnimalList_)
        {
            Debug.Log($"obj 확인 : {obj}");
        }

        string jsonData = ObjectToJson(battleTileObject);
        
        foreach(object obj in battleAnimalList_)
        {
            Debug.Log($"그냥데이터 : {obj}");
        }
        Debug.Log($"제이슨 데이터 : {jsonData}");
        GFunc.LoadScene("04.BattleScene");
    }
    string ObjectToJson(object obj)
    {
        return JsonUtility.ToJson(obj);
    }
    T JsonToObject<T>(string jsonData)
    {
        return JsonUtility.FromJson<T>(jsonData);
    }
}
