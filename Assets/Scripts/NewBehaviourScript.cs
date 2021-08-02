using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Destination;
    private NavMeshAgent agent;
    public GameObject bodyPrefab;
    public GameObject head;
    private int length;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        length = 1;
        for (int n = 0; n < length; n++)
        {
            GameObject body = Instantiate(bodyPrefab, transform);
            body.transform.position = new Vector3(head.transform.position.x, head.transform.position.y, head.transform.position.z - n - 1);

        }

        // Update is called once per frame


    }
    void Update()
    {
        if (canvas.transform.GetChild(0).gameObject.activeSelf == false)
        {
            agent = GetComponent<NavMeshAgent>();
            agent.SetDestination(Destination.transform.position);
        }
    }
    public void getApple()
    {
        GameObject body = Instantiate(bodyPrefab, transform);
        body.transform.position = transform.GetChild(length - 1).position;
        length++;
    }

}
