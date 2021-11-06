using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Universe
{
    public class CameraCucc : MonoBehaviour
    {
        public Vector3 offset;

        public GameObject camera;
        public GameObject character;
        void Start()
        {
            
        }

        void LateUpdate()
        {
            camera.transform.position = character.transform.position + offset;
        }
    }
}

