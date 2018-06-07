using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.ThirdPersonController.Wrappers;
public class collisionWithGhosts : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter(Collider info)
    {
        if (info.CompareTag("Ghost"))
        {
            GetComponent<CharacterHealth>().Damage(5, this.transform.position, Vector3.zero);
        }
    }
}
