using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] LayerMask layer;
    [SerializeField] float radius;
    [SerializeField] Collider[] col;

    void Start()
    {
        InvokeRepeating("enemyaround", 0, 0.2f);
    }

    void enemyaround()
    {
        col = Physics.OverlapSphere(player.transform.position, radius, layer);
    }
}
