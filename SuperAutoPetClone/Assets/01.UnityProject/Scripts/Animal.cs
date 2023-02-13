using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Animal : MonoBehaviour
{
    private int hp;
    private int damage;
    public int HP{
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
