using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Production : MonoBehaviour
{
    public float productionRate;
    public float producedItem;

    Plant plant;
    Quaters quaters;


    // Start is called before the first frame update
    void Start()
    {
        plant = FindObjectOfType<Plant>();
        quaters = FindObjectOfType<Quaters>();
        StartCoroutine("DoCheck");
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    

    public void AddNewProduction()
    {
        //Add worker
        productionRate++;
        
        //Add worker to quaters
        plant.UpdatePlant(productionRate);
    }

    public void DecreaseProduction()
    {
        if (productionRate > 1.01)
            productionRate = productionRate - 0.001f; 

        plant.UpdatePlant(productionRate);
        plant.UpdatePlantHealth();
    }

    

    IEnumerator DoCheck()
    {
        for (; ; )
        {
            CreateProduct();
            yield return new WaitForSeconds(2);
        }
    }
    public void CreateProduct()
    {
        producedItem += quaters.currentWorkersCount * productionRate;
    }
}
