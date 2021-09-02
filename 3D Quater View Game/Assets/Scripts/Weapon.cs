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
    
    public void Use()
    {
        if(type == Type.Melee)
        {
            StopCoroutine("Swing");  // �������� �ڷ�ƾ�� �����Ȳ�� ������� ������Ŵ.
            StartCoroutine("Swing"); // �ڷ�ƾ �Լ��� �׳� ���� �ȵǰ� ��ŸƮ�ڷ�ƾ �Լ��� �̿��ؾ���
        }
    }


    // �ڷ�ƾ�̶�?
    // �Ϲ������� ���� �Լ����� ���� �Լ��� ���� �� ���� ������ �̾ �����ϴ� �Ͱ� �޸�
    // �ڷ�ƾ�� �Լ��� ���ÿ� �����Ű�� ���� �ǹ��Ѵ�.

    IEnumerator Swing()
    {
        // 1
        yield return new WaitForSeconds(0.1f); // return null�� ������ ���� �� 1������ ���
                                               // �� �Լ��� ��� n�� ���
        meleeArea.enabled = true;
        trailEffect.enabled = true;

        yield return new WaitForSeconds(0.3f);
        meleeArea.enabled = false;

        yield return new WaitForSeconds(0.3f);
        trailEffect.enabled = false;

        // yield break;  ��ó�� break�� ���� �ڷ�ƾ Ż�� ���
    }
}
