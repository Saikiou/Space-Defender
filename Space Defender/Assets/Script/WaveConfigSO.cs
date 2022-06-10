using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave config", fileName = "New Wave config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] Transform pathPrefabs;
    [SerializeField] float moveSpeed = 5f;

    public Transform GetStartingWayPoint()
    {
        return pathPrefabs.GetChild(0);

    }

    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach (Transform child in pathPrefabs)
        {
            waypoints.Add(child);
        }
        return waypoints;


    }

    public float getMoveSpeed()
    {
        return moveSpeed;

    }

}
