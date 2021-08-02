using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeController : MonoBehaviour
{
    public GameObject bodyPrefab;
    public GameObject head;
    public GameObject canvas;
    private int length;
    private int score;
    private Vector3 up = new Vector3(0, 0, 1);
    private Vector3 down = new Vector3(0, 0, -1);
    private Vector3 left = new Vector3(-1, 0, 0);
    private Vector3 right = new Vector3(1, 0, 0);

    private Vector3 direction;

    private float timer;
    public float threshold;
    private int speedUp;
    public Slider energyBar;
    private float energy;
    // Start is called before the first frame update
    void Start()
    {
        energy = 200;
        speedUp = 1; 
        length = 3;
        direction = up;
        timer = 0;
        score = 0;
        for (int n = 0; n < length; n++)
        {
            GameObject body = Instantiate(bodyPrefab, transform);
            body.transform.position = new Vector3(head.transform.position.x, head.transform.position.y, head.transform.position.z - n - 1);
            if (n > 0)
                body.GetComponent<GameOver>().canvas = canvas.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.GetChild(1).GetComponent<Text>().text = "Score:" + score;
        energyBar.value = energy;
        if (canvas.transform.GetChild(0).gameObject.activeSelf == false)
        {
            if(Input.GetKey (KeyCode.LeftShift )&&energy >1.0f)
            {
                speedUp = 2;
                if (energy > 0.5f)
                {
                    energy -= 0.5f;
                }
            }
            else
            {
                speedUp = 1;
                energy += 0.01f;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (!(transform.GetChild(0).position.z > head.transform.position.z))
                    direction = up;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (!(transform.GetChild(0).position.z < head.transform.position.z))
                    direction = down;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                if (!(transform.GetChild(0).position.x < head.transform.position.x))
                    direction = left;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (!(transform.GetChild(0).position.x > head.transform.position.x))
                    direction = right;
            }
            if (timer > threshold/speedUp )
            {
                for (int n = length - 1; n > 0; n--)
                {
                    transform.GetChild(n).transform.position = transform.GetChild(n - 1).transform.position;
                }
                transform.GetChild(0).transform.position = head.transform.position;
                head.transform.position += direction;
                timer = 0;
            }
     
            timer += Time.deltaTime;

        }
    }
    public void getApple()
    {

        GameObject body = Instantiate(bodyPrefab, transform);
        body.GetComponent<GameOver>().canvas = canvas.gameObject;
        body.transform.position = transform.GetChild(length - 1).position;
        length++;
        score++;
        if (threshold > 0.1f)
        {
            threshold -= 0.05f;
        }
    }
}
