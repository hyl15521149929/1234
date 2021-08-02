using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    public GameObject enemysnake;
    public GameObject playersnake;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Head")
        {
            enemysnake.GetComponent<NewBehaviourScript>().getApple();
            int x = Random.Range(0, 19);
            int z = Random.Range(0, 19);
            transform.position = new Vector3(x + 0.5f, 0, z + 0.5f);
        }
      if (col.name == "Body(Clone)")
        {
            int x = Random.Range(0, 19);
            int z = Random.Range(0, 19);
            transform.position = new Vector3(x + 0.5f, 0, z + 0.5f);
        }
        if (col.name == "Player Head")
        {
            playersnake.GetComponent<SnakeController>().getApple();
            int x = Random.Range(0, 19);
            int z = Random.Range(0, 19);
            transform.position = new Vector3(x + 0.5f, 0, z + 0.5f);
        }
        else if (col.name == "Body(Clone)")
        {
            int x = Random.Range(0, 19);
            int z = Random.Range(0, 19);
            transform.position = new Vector3(x + 0.5f, 0, z + 0.5f);
        }
    }

}
