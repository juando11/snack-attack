using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.S)) 
      {
        int animalIndex = Random.Range(0, animalprefabs.Length);
        Instantiate(animalprefabs[animalIndex],new Vector3(Random.Range(-13,13), 18, Random.Range(-13,13)), animalprefabs[animalIndex].transform.rotation);
      }
      
    }
{
void OnCollisionEnter(collision collision)
}
 if(collision.gameObjects.tag == "badTag")

}