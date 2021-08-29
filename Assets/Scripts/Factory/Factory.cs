using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Factory : MonoBehaviour
{

    Workers workers;
    Quaters quaters;
    FactoryStats factoryStats;
    Production production;

    // Start is called before the first frame update
    void Start()
    {
        workers = FindObjectOfType<Workers>();
        quaters = FindObjectOfType<Quaters>();
        production = FindObjectOfType<Production>();
        factoryStats = FindObjectOfType<FactoryStats>();
    }

    // Update is called once per frame
    void Update()
    {
        factoryStats.GetCurrentFactoryStats();
        production.DecreaseProduction();

    }

    

    public void CheckUserInput(Button button)
    {
        switch (button.name)
        {
            case "AddWorkers":
                workers.AddNewWorker();
                break;
            case "AddProduction":
                if (quaters.quaters_Available > 0)
                   production.AddNewProduction();
                break;
            default:
                
                break;
        }
    }

    

    
}