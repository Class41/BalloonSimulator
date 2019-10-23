﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope_restrictballmovement : MonoBehaviour
{
    public Transform _balloon;
    public float[] bounds = new float[] {-6.5f, 6.5f, 0f, 6.5f};

    // Update is called once per frame
    void Update()
    {
        float clampedX = Mathf.Clamp(_balloon.position.x, bounds[0], bounds[1]);
        float clampedY = Mathf.Clamp(_balloon.position.y, bounds[2], bounds[3]);

        _balloon.position = new Vector3(clampedX, clampedY, _balloon.position.z);
    }
}
