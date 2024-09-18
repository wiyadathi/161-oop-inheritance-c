using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class IronMan
{
    // Attributtes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;

    // Constructor
    public IronMan(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;

        armorStrength = 10;
    }
    // หลบการโจมตี
    public void Fly()
    {
        Debug.Log($"--- {Name} is flying");
    }
    // โจมจี
    public void ShootLaser()
    {
        Debug.Log($"---{Name} shoots Laser");
    }
    // อัพเดดชุดเกราะ
    public void UpdateStrength(float armorStrength)
    {
        Debug.Log($"--- {Name} updated armor");
    }
    // เช็ค hp และรีเทิร์นว่าตายรียัง
    public bool IsDead()
    {
        return Hp <= 0;
    }
    // ลด hp จาก Dm ที่ได้รับมา
    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log($"{Name} took {damage} damage,---Current HP: {Hp}");

        if (IsDead())
        {
            Debug.Log($"---{Name} is dead!");
        }
    }

}
