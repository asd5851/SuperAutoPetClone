using System.Collections;
using System.Collections.Generic;
using UnityEngine;

            [SelectionBase]
public class S_ShopManager : MonoBehaviour
{
    public GameObject animalObj = default;
    GameObject tempObj = default;
    public List<GameObject> shopTileObj = default;
    void Start()
    {
        for(int i=0;i<3;i++)
        {
           tempObj = Instantiate(animalObj,shopTileObj[i].transform.position, Quaternion.identity,shopTileObj[i].transform);
           tempObj.GetComponent<RectTransform>().localScale = new Vector2(-1,1);
        }
    }

    

}
