using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_TileAction : MonoBehaviour
{
    bool isClicked = false;
    Image ArrowImg = default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //! 마우스가 위에 있을 경우
    void OnMouseEnter()
    {
        Debug.Log("마우스가위에있따.");
        if(isClicked == true)
        {
            ArrowImg = gameObject.FindChildObj("TileEnter").GetComponent<Image>();
            ArrowImg.color = new Color(1,1,1);
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
        isClicked = true;
        gameObject.FindChildObj("TileEnter").SetActive(true);
        gameObject.FindChildObj("TileArrow").SetActive(true);
    }

}
