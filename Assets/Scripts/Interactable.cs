﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {
	[HideInInspector]
    public NavMeshAgent playerAgent;
	private bool hasInteracted;

    public virtual void MoveToInteraction(NavMeshAgent playerAgent)
    {
		hasInteracted = false;
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 3.2f;
        playerAgent.destination = this.transform.position;

    }

	void Update(){
		if (null != playerAgent && !playerAgent.pathPending&&!hasInteracted) {
			if (playerAgent.remainingDistance <= playerAgent.stoppingDistance) {
				Interact();
				hasInteracted = true;
			}
		}
	}

    public virtual void Interact()
    {
        Debug.Log("interacting with base class");
    }
}
