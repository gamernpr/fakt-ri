using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Workers : MonoBehaviour
{
    public int workersCount;
    public float healthAvailable;
     
    
    


    Quaters quaters;


    // Start is called before the first frame update
    void Start()
    {
       quaters = FindObjectOfType<Quaters>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewWorker()
    {
        //Add worker
        workersCount++;
         
       

        //Add worker to quaters
        quaters.UpdateQuaters(workersCount);
        
    }

    public void DecreaseWorker()
    {
        

    }
}
