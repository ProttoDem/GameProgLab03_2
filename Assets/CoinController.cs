using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] Transform door;

    private int score = 0;
    private bool doorIsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Coin")
        {
            score = score + 1;
            col.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 1 && !doorIsOpen)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        door.Rotate(0, 90, 0, Space.Self);
        doorIsOpen = true;
    }
}
