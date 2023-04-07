using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Player" || other.name.StartsWith("Enemy"))
        {
            GameManager.Instance.endGame = true;
            other.GetComponent<Character>().transform.position = new Vector3(0.01962265f, 9.42f, 80.29436f);
        }
    }
}