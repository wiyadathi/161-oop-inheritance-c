using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //สร้างobj 
        IronMan ironMan = new IronMan("Iron Man", 100, "Red");
        CaptainAmerica captainAmerica = new CaptainAmerica("CaptainAmerica", 100, "Blue");

        Debug.Log($"--- {ironMan.Name}, HP: {ironMan.Hp}");
        Debug.Log($"--- {captainAmerica.Name}, HP: {captainAmerica.Hp}");
        // ลูปจนกว่าจะมีคนตายในการต่อสู้จริงๆนะ
        while (!ironMan.IsDead() && !captainAmerica.IsDead())
        {
            ironMan.ShootLaser();
            captainAmerica.TakeDamage(Random.Range(10, 21));

            captainAmerica.ThrowShield();
            ironMan.TakeDamage(Random.Range(10, 21));
        }
    }


}
