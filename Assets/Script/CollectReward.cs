using UnityEngine;

public class CollectReward : MonoBehaviour
{
    //  [SerializeField] private GameObject star;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
       if(collider.CompareTag("Player"))
       {
         Destroy(gameObject);
         Debug.Log("Collect Reward");
       }
    }
}
