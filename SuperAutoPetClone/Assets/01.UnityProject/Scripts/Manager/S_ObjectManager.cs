using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
클릭했을때 -> tile에 animal 붙어있을경우 -> 정보가지고감
-> 다음클릭시 battletile 일 경우 -> animal을 battletile 하위에 넣는다.
-> 다음클릭시 shoptile 일 경우 -> animal 정보를 변경한다.

*/
public class BattleTileObject: MonoBehaviour
{
    public List<GameObject> battleAnimalList = new List<GameObject>();
    void Start()
    {
        battleAnimalList = default;

    }
    
}
public class S_ObjectManager : MonoBehaviour
{
    public bool isClicked_ = false;
    GameObject  selectedAnimal_ = default;
    public GameObject battleTileParent = default;
    public List<GameObject> battleAnimalList = default;
    public GameObject[] battleTile = default;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            battleTile[i] = GameObject.Find("BattleTile").transform.Find("BattleTile" + i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //! 선택된 동물을 가져온다.
    public void GetSelectedAnimal(GameObject selectedAnimal, bool isClicked)
    {
        isClicked_ = isClicked;
        selectedAnimal_ = selectedAnimal;
        Debug.Log($"선택된 동물 : {selectedAnimal_}, 클릭 되었나? : {isClicked_}");
    }

    //! 다음 선택이 battletile인지 shoptile인지 구분한다.
    public void WhatTile(GameObject tileObj)
    {
        GameObject parentObj = tileObj.transform.parent.gameObject;
        // 선택된 상태일 때
        if (isClicked_ == true)
        {
            if (parentObj.name == "BattleTile")
            {
                Debug.Log("무슨타일");
                tileObj.transform.SetParent(selectedAnimal_.transform);
            }
            else if (parentObj.name == "ShopTile")
            {

            }
            else
            {

            }
        }

    }

    //! 선택된 동물을 battletile의 하위에 넣는다.
    public GameObject SetSelectedAnimal()
    {
        return selectedAnimal_;
    }

    //! 배틀탭에 있는 오브젝트를 서치한다.
    public void SearchBattleAnimal(GameObject target)
    {
        Transform[] allChildren = target.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            if(child.gameObject.tag == "Animal")
            {
                battleAnimalList.Add(child.gameObject);
                Debug.Log($"찾은 이름 : {child.name}");
            }  
        }
        
    }
    //! 턴 종료 버튼을 누르면 배틀탭의 오브젝트를 서치하는 함수 호출
    
}
