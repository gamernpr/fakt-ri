using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{

    public int inputProdCount;
    public double plantProductionRate;
    public int plantThreshold = 100;
    public double plantAvailableBandwidth;

    public double plant_Health;
    public double plant_Health_Threshold = 100;

    Production production;

    // Start is called before the first frame update
    void Start()
    {
        production = FindObjectOfType<Production>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePlant(double _productionRate)
    {
        plantProductionRate = _productionRate;
        plantAvailableBandwidth = plantThreshold - plantProductionRate;
    }

    public void UpdatePlantHealth()
    {

        double health_Rate = production.producedItem / 100;
        plant_Health = plant_Health_Threshold - (health_Rate);

    }
}
