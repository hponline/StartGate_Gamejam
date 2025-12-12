using UnityEngine;

namespace Game.Combat
{
    public sealed class BaseTarget : MonoBehaviour
    {
        public Vector3 Position => transform.position;
    }
}
