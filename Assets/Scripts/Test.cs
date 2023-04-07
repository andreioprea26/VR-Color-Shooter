using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Test : MonoBehaviour
{
    
    float randomNR;
    
    

    void Start()
    {
        randomNR = Random.Range(0, 100);
    }

    Vector3 GeneratedPosition()
    {
        float x, y, z;
        x = Random.Range(-4.8f, 4.8f);
        y = 1;
        z = Random.Range(-4.8f, 4.8f);
        return new Vector3(x, y, z);
    }
    
    public void MoveCubeOnCollision(Collision collision)
    {
        if (gameObject.layer == LayerMask.NameToLayer("RED") && collision.gameObject.layer == LayerMask.NameToLayer("RED"))
        {
            gameObject.transform.position = new Vector3(Random.Range(-4.8f, 4.8f), 1, Random.Range(-4.8f, 4.8f));
            randomNR = Random.Range(0, 100);
            Scor.instance.AddPoint();
        }
        else if (gameObject.layer == LayerMask.NameToLayer("BLUE") && collision.gameObject.layer == LayerMask.NameToLayer("BLUE"))
        {
            gameObject.transform.position = new Vector3(Random.Range(-4.8f, 4.8f), 1, Random.Range(-4.8f, 4.8f));
            randomNR = Random.Range(0, 100);
            Scor.instance.AddPoint();

        }
    }

    public void SpawnClone()
    {
        if (randomNR > 80)
        {
            Instantiate(gameObject, GeneratedPosition(), Quaternion.identity);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        MoveCubeOnCollision(collision);
        SpawnClone();
    }
}
