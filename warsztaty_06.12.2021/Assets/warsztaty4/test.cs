using System;
using DG.Tweening;
using UnityEngine;

public class test : MonoBehaviour
{
    private float counter;

    private void Update()
    {
        /*
        this.counter += Time.deltaTime;
        transform.position = new Vector3(
            // Mathf.Sin(this.counter),
            transform.position.x,
            // Mathf.Tan(this.counter),
            Mathfx.Berp(-1, 1, this.counter%1),
            transform.position.z
        );
        */

        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        var dest = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        DOTween.To(() => this.transform.position, x => this.transform.position = x, dest, 1);
        
        
    }
}
