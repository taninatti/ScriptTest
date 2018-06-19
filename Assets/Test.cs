using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss : MonoBehaviour
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    public void Magic(int magic)
    {
        this.mp = this.mp - magic;
        Debug.Log("魔法攻撃をした。残りMPは"+ this.mp);
        for (int i = 0; i < 10; i++)
        {
            this.mp = this.mp - magic;
            if (mp < 5)
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    
    }
}

public class Test : MonoBehaviour
{

    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic(5);
    }
}








