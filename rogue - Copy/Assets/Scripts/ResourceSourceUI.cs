using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSourceUI : MonoBehaviour
{
    public GameObject selectionBox;
    public GameObject player;
    public float nearestDist;
    public ResourceSource resource;
     private void Awake() {
        resource = GetComponent<ResourceSource>();
    }
     private void OnMouseOver() {
         if(Vector2.Distance(player.transform.position, gameObject.transform.position) <= nearestDist){
                selectionBox.SetActive(true);
        }else{
            selectionBox.SetActive(false);
        }
    }
    private void OnMouseEnter()
    {
        if(Vector2.Distance(player.transform.position, gameObject.transform.position) <= nearestDist){
                selectionBox.SetActive(true);
        }else{
            selectionBox.SetActive(false);
        }
    
    }
    private void OnMouseExit() {
        selectionBox.SetActive(false);
    }
}
