using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BattleTileAction : MonoBehaviour
{
    GameObject[] battleTile_ = default;
    GameObject objManager = default;
    S_ObjectManager objManagerScript = default;
    bool isClicked = false;
    void Start()
    {
        battleTile_ = new GameObject[6];
        for (int i = 1; i <= 5; i++)
        {
            //Debug.Log("BattleTile"+i);
            battleTile_[i] = GameObject.Find("BattleTile" + i).transform.GetChild(1).gameObject;
        }
        objManager = GameObject.Find("ObjectManager");
        objManagerScript = objManager.GetComponent<S_ObjectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        isClicked = objManagerScript.isClicked_;
        //Debug.Log(isClicked);
    }
    void OnMouseEnter()
    {
        
        {
            gameObject.FindChildObj("TileEnter").gameObject.SetActive(true);
        }
        
    }
    void OnMouseUp()
    {
        // 뭔가가 선택된 상태다
        if (isClicked == true)
        {
            objManagerScript.SetSelectedAnimal().transform.SetParent(gameObject.transform);
            objManagerScript.SetSelectedAnimal().transform.position = gameObject.transform.position;
            
            for(int i=1;i<=5;i++)
            {
                GameObject.Find("BattleTile"+i).FindChildObj("TileArrow").SetActive(false);
            }
            isClicked = false;
            objManagerScript.GetSelectedAnimal(null,isClicked);
        }
        else
        {
            if(gameObject.FindChildObjWithTag("Animal").gameObject)
            {
                isClicked = true;
                objManagerScript.GetSelectedAnimal(gameObject.FindChildObjWithTag("Animal").gameObject,isClicked);
            }
        }
    }
    void OnMouseExit()
    {
        if(isClicked == true)
        {
            gameObject.FindChildObj("TileEnter").gameObject.SetActive(false);
        }
        else
        {
            gameObject.FindChildObj("TileEnter").gameObject.SetActive(false);   
        }
    }

    //! 화살표 활성화
    public void AcitveArrow()
    {
        for (int i = 1; i <= 5; i++)
        {
            battleTile_[i].gameObject.SetActive(true);
        }
    }
}



// 클릭한 상태면 클릭한 놈은 나타난다. 다른놈은 마우스가 근처에 갈때 나타난다.
// 클릭한 상태면 클릭한 놈은 지워지지 않는다. 다른놈은 마우스가 빠져나가면 지워진다.
// 클릭하지 않은 상태면 마우스가 근처에 갈때 나타난다.
// 클릭하지 않은 상태면 마우스가 빠져나가면 지워진다.