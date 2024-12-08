using System;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] LayerMask layer;
    [SerializeField] float radius;
    [SerializeField] Collider[] col;
    [SerializeField] Transform target;

    void Start()
    {
        InvokeRepeating("enemyaround", 0, 0.2f);
    }

    void enemyaround()
    {
        col = Physics.OverlapSphere(player.transform.position, radius, layer);

        Transform short_enemy = null;

        if (col.Length > 0)
        {
            float short_distance = Mathf.Infinity;

            foreach (Collider s_col in col)
            {
                float playertoenemy = Vector3.SqrMagnitude(player.transform.position - s_col.transform.position);

                if (short_distance > playertoenemy)
                {
                    short_distance = playertoenemy;
                    short_enemy = s_col.transform;
                }
            }
        }
        target = short_enemy;
    }
}
