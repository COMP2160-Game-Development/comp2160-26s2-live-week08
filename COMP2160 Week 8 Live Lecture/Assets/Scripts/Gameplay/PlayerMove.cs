/**
 * 
 * Author: Malcolm Ryan
 * Version: 1.0
 * For Unity Version: 6000.0.53f1
 */

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{

#region Parameters
    [Tooltip("m/s")]
    [SerializeField] private float speed = 5f;
#endregion 

#region Components
    private Rigidbody2D rigidbody;
#endregion

#region State
#endregion

#region Properties
#endregion

#region Events    
#endregion

#region Init & Destroy
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.constaints = RigidbodyConstraints2D.FreezeRotation;
    }
#endregion 

#region Update
    void Update()
    {
    }
#endregion

#region FixedUpdate
    void FixedUpdate()
    {
        rigidbody.linearVelocity = speed * Vector2.right;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
#endregion

#region Gizmos
    void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Don't run in the editor
            return;
        }
    }
#endregion
}
