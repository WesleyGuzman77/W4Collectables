using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    int score = 0;
    public TMP_Text scoreText;
    public TMP_Text timeText;
    float time = 30;

    public GameObject gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            Vector3 currentPos = transform.position;

            if (Input.GetKey(KeyCode.D))
            {
                currentPos.x = currentPos.x + speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                currentPos.x = currentPos.x - speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.W))
            {
                currentPos.z = currentPos.z + speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                currentPos.z = currentPos.z - speed * Time.deltaTime;
            }

            transform.position = currentPos;

            time -= Time.deltaTime;
            int timeInt = Mathf.RoundToInt(time);
            timeText.text = timeInt.ToString();
        }
        else
        {
            gameOverText.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect")
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }


}
