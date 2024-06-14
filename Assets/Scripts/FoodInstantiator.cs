using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos; 
    public Transform clonePoint; 
    public float interval; 
    public RandomPlacement posicionAleatoriaDeClonPoint;  
    public int maxAlimentos; 

    private int currentAlimentos = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood), 0, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if (currentAlimentos < maxAlimentos)
        {
            posicionAleatoriaDeClonPoint.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
            currentAlimentos++;
        }
        
    }
}
