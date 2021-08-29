using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FactoryStats : MonoBehaviour
{

    //Quaters variables
    Quaters quaters;
    private object quatersStats;
    public float quaterHealth;

    //Plant variables
    Plant plant;
    private object plantStats;
    public float plantHealth;

    //Production variabled
    Production production;

    //Revenue Variables
    //RevenueManager revenueManager;

    //Text Variables
    public Text T_QuatersHealth;
    public Text T_Quatersavailable;
    public Text T_WorkersCount;
    public Text T_ProductionRate;
    public Text T_ProducedItems;
    public Text T_PlantHealth;
    public Text T_Wealth;




    // Start is called before the first frame update
    void Start()
    {
        quaters = FindObjectOfType<Quaters>();
        plant = FindObjectOfType<Plant>();
        production = FindObjectOfType<Production>();
        //revenueManager = FindObjectOfType<RevenueManager>();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCurrentFactoryStats()
    {

        
        //Quaters Stats
        quaterHealth = quaters.currentHealth;
        T_Quatersavailable.text = quaters.quaters_Available.ToString();
        T_QuatersHealth.text = quaters.currentHealth.ToString();
        T_WorkersCount.text = quaters.currentWorkersCount.ToString();

        //Plant stats
        T_ProductionRate.text = plant.plantProductionRate.ToString();
        T_PlantHealth.text = plant.plant_Health.ToString();

        //Production stats
        T_ProducedItems.text = production.producedItem.ToString();

        //Revenue Stats
        //T_Wealth.text = revenueManager.ProductSales.ToString();


    }

}
