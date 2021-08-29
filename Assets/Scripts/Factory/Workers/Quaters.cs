using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaters : MonoBehaviour
{
    
    public int quaters_Threshold = 100;
    private int quaters_Balance;
    public int quaters_Available;
    public int currentWorkersCount;
    public int quaters_WorkerCount;
    
    public float quaters_Health_Threshold = 100;
    public float quaters_Health;
    public float currentHealth;
    


    void Update()
    {
        SetQuatersStats();
    }

    public void UpdateQuaters(int _workersCount)
    {
        quaters_WorkerCount = _workersCount;
        quaters_Balance = quaters_Threshold - _workersCount;
        UpdateQuatersHealth(); 
    }

    public void UpdateQuatersHealth()
    {
        
        float health_Rate = quaters_WorkerCount / 10;
        quaters_Health = quaters_Health_Threshold - (health_Rate);
         
    }

    void SetQuatersStats()
    {
        currentHealth = quaters_Health;
        quaters_Available = quaters_Balance;
        currentWorkersCount = quaters_WorkerCount;
    }
}
