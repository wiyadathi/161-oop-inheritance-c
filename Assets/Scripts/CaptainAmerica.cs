using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica
{
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength;

    public CaptainAmerica(string newName, int newHp, string newSuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newSuitColor;

        armorStrength = 10;
    }
    // หลบการโจมตี
    public void LeapAndJump()
    {
        Debug.Log($"{Name}---Jump---");
    }
    // โจมตี
    public void ThrowShield()
    {
        Debug.Log($"{Name}---Throw Shields---");
    }
    // อัพเดดชุดเกราะ
    public void UpdateStrength(float strength)
    {
        Debug.Log($"{Name}---UpdateStrength---");
    }

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
