using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar _healthBar;
    public UnitHealth _enemyHealth = new UnitHealth(100, 100);

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightAlt))
              {
            EnemyTakeDmg(10);
            Debug.Log(_enemyHealth.Health);
        }
    }
    
    private void EnemyTakeDmg(int dmg)
    {
        _enemyHealth.DmgUnit(dmg);
        _healthBar.SetHealth(_enemyHealth.Health);
    }

    
}
