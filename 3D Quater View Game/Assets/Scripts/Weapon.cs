using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public enum Type { Melee, Range};
    public Type type;
    public int damage; // ���ݷ�
    public float rate; // ���� �ӵ�
    public BoxCollider meleeArea; // ���� ����
    public TrailRenderer trailEffect; // ���� ����Ʈ
    
}
