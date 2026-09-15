/**
 * 
 * Author: Malcolm Ryan
 * Version: 1.0
 * For Unity Version: 6000.0.53f1
 */

using UnityEngine;

public class UIManager : MonoBehaviour
{

#region Parameters



#endregion 

#region Connected Objects
#endregion

#region Components
#endregion

#region State
#endregion

#region Properties
static private UIManager instance;
static public UIManager Instance
{
    get
    {
        if (instance == null)
        {
            Debug.LogError("No UI Manager");
        }

        return instance;    
    }
}

#endregion

#region Events
#endregion

#region Init & Destroy
    void Awake()
    {
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
