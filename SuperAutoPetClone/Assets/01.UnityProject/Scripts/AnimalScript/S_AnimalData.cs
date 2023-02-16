using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Anmial Data",menuName = "Scriptable_Object/Animal Data", order = int.MaxValue)] // 상속받는 클래스를 스크립터블 오브젝트 에셋으로 생성해준다.
public class S_AnimalData : ScriptableObject
{
    [SerializeField]
    private string animalName;
    public string AnimalName {get {return animalName;}}

    [SerializeField]
    private int hp;
    public int Hp {get{return hp;}}

    [SerializeField]
    private int damage;
    public int Damage{get{return damage;}}
    
    void Skill()
    {
        
    }
}
