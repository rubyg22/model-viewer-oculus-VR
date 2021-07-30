using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAvatar : MonoBehaviour
{
    [SerializeField] Transform Phrase;
   // public GameObject ;
    
    void Update()
    {
        transform.LookAt(Phrase);
  
    }
}
