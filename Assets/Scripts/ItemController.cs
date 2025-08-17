using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject potionObject;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;
    public float minInitialDelay=10f;
    public float maxInitialDelay=15f;
    public float displayDuration=7f;
    public float minSpawnInterval=20f;
    public float maxSpawnInterval=40f;

    // Start is called before the first frame update
    void Start()
    {
        if(potionObject == null){
            return;
        }

        potionObject.SetActive(false);

        StartCoroutine(SpawnRoutine());
        
    }

    IEnumerator SpawnRoutine(){
        float initialDelay =Random.Range(minInitialDelay, maxInitialDelay);
        yield return new WaitForSeconds(initialDelay);

        while(true){
            float randomX =Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float randomY =Random.Range(spawnAreaMin.y, spawnAreaMax.y);

            potionObject.transform.position=new Vector2(randomX, randomY);

            

            SpriteRenderer spriteRenderer=potionObject.GetComponent<SpriteRenderer>();
            if(spriteRenderer == null || spriteRenderer.sprite == null){
                Debug.LogWarning($"SpriteRenderer is missing or has no sprite assigned on '{potionObject.name}'!");
            }
            else {
                Debug.Log($"SpriteRenderer active, Sprite: {spriteRenderer.sprite.name}");

            }

            yield return new WaitForSeconds(displayDuration);

            potionObject.SetActive(false);

        }
    }

    void OnDrawGizmos(){
        Gizmos.color=Color.red;
        Vector2 center=(spawnAreaMin+spawnAreaMax)/2f;
        Vector2 size=spawnAreaMax-spawnAreaMin;
        Gizmos.DrawWireCube(center, size);
    }
}
