using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject toTriggerObjectBlue;
    public GameObject toTriggerObjectRed;
    public GameObject toTriggerObjectGreen;

    void Start()
    {
        toTriggerObjectBlue.SetActive(false);
        toTriggerObjectRed.SetActive(false);
        toTriggerObjectGreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            toTriggerObjectBlue.SetActive(true);
            toTriggerObjectRed.SetActive(true);
            toTriggerObjectGreen.SetActive(true);
        }
    }
}
