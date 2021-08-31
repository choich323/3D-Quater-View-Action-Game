using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public enum Type { Melee, Range};
    public Type type;
    public int damage; // 공격력
    public float rate; // 공격 속도
    public BoxCollider meleeArea; // 공격 범위
    public TrailRenderer trailEffect; // 공격 이펙트
    
}
