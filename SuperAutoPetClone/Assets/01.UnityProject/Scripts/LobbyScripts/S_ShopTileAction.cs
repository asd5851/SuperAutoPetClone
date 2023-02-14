using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_ShopTileAction : MonoBehaviour
{
    bool isClicked = false;
    Image ArrowImg = default;

    GameObject selectedAnimal = default;
    GameObject findAnimal = default;
    public GameObject[] battleTile = default;
    S_BattleTileAction battleTileAction = default;
    GameObject objManager = default;
    S_ObjectManager objManagerScript = default;


    // 자식 오브젝트의 
    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            battleTileAction = battleTile[i].GetComponent<S_BattleTileAction>();
        }
        objManager = GameObject.Find("ObjectManager");
        objManagerScript = objManager.GetComponentMust<S_ObjectManager>();
        findAnimal = gameObject.FindChildObjWithTag("Animal").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (!findAnimal)
        {
            gameObject.FindChildObj("TileEnter").gameObject.SetActive(false);
        }
    }

    //! 마우스가 위에 있을 경우
    void OnMouseEnter()
    {
        //Debug.Log("마우스가위에있따.");
        if (isClicked == true)
        {
            ArrowImg = gameObject.FindChildObj("TileEnter").GetComponent<Image>();
        }
        else
        {
            gameObject.FindChildObj("TileEnter").SetActive(true);
        }
    }

    //! 마우스가 빠져나왔을 경우
    void OnMouseExit()
    {

        gameObject.FindChildObj("TileEnter").SetActive(false);

    }

    //! 마우스를 클릭했을 경우
    void OnMouseUp()
    {
        //Debug.Log(gameObject.FindChildObj("Ant(Clone)"));

        // 동물오브젝트가 있고 클릭이 되지 않았을 경우에만
        if (findAnimal && isClicked == false)
        {
            isClicked = true; // 클릭 true
            selectedAnimal = findAnimal; // 선택된 동물저장
            gameObject.FindChildObj("TileEnter").SetActive(true); // 선택하면 표시한다.
            battleTileAction.AcitveArrow(); // 배틀타일에 접근해서 화살표를 등장시킨다.
            objManagerScript.GetSelectedAnimal(selectedAnimal, isClicked); // 선택한 타일의 동물정보 제공
            objManagerScript.WhatTile(gameObject); // 오브젝트매니저가 무슨타일인지 판단한다.

        }
        // 클릭을 하고 다음 클릭일 때
        else if (isClicked == true)
        {

        }



    }

}
