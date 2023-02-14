using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Animal : MonoBehaviour
{
    private int hp;
    private int damage;
    protected int HP{
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
    protected int Damage
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
    protected void TakeDamage(int Enemydamage)
    {
        HP -= Enemydamage;
    }
    
    //! 죽었을 경우
    protected void Die()
    {

    }

    
}
