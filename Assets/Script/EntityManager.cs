using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class EntityManager
    {
        protected List<Transform> entities = new();
        public Vector2 NearestEntityPosition(Vector3 towerPosition)
        {
            float minDistance = Mathf.Infinity;
            Vector2 result = Vector2.zero;
            foreach (Transform t in entities)
            {
                float distance = Vector2.Distance(t.position, towerPosition);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    result = t.position;
                }
            }
            return result;
        }
    }

}
