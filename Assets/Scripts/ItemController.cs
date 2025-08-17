using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject potionObject;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;
    public float minInitialDelay=10f;
    public float maxInitialDelay=7f;
    public float minSpawnInterval=20f;
    public float maxSpawnInterval=40f;

    // Start is called before the first frame update
    void Start()
    {
        if(potionObject == null){
            return;
        }

        potionObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
