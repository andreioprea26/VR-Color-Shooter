using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReward : MonoBehaviour
{
    public GameObject powerUp;
    float randomNR;

    private void Start()
    {
        randomNR = Random.Range(0, 100);
    }

    public void SpawnPowerUp(Collision collision)
    {
        if (gameObject.layer == LayerMask.NameToLayer("RED") && collision.gameObject.layer == LayerMask.NameToLayer("RED"))
        {
            Instantiate(powerUp, gameObject.transform.position, Quaternion.identity);
        }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if(randomNR> 2)
        {
            SpawnPowerUp(collision);
        }
    }
}
