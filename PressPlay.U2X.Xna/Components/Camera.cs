﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace PressPlay.U2X.Xna.Components
{
    public class Camera
    {
        public Camera()
        {
            transform = new Transform();
        }
        
        public static Camera main = new Camera();

        public Transform transform { get; set; }

        public Matrix View()
        {
            return Matrix.CreateLookAt(
                transform.localPosition,
                transform.localPosition + Vector3.Transform(Vector3.Forward, transform.localRotation),
                Vector3.Up);            
        }

        public Matrix projectionMatrix { get; set; }
    }
}
