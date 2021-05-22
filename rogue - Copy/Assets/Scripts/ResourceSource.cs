using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResourceSource : MonoBehaviour
{
    public GameObject player;
    private float nearestDist = 3f;
    public GameObject wood;

    public enum ResourceType{
        Food,
        Material
    }
    public ResourceType type;
    public int quantity;
     private void OnMouseUp() {
         if(Vector2.Distance(player.transform.position, gameObject.transform.position) <= nearestDist){
                     GatherResource(1);
         }

    }

    public void GatherResource(int amount)
    {
        quantity -= amount;
        if(quantity <= 0){
            Instantiate(wood, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
