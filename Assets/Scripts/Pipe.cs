using System.Collections;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    PointsUI pointsUi;

    private void Start() => pointsUi = FindObjectOfType<PointsUI>();
    
    private float pipeDistance = 4f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(PreparePipe());
        pointsUi.AddPoint();
    }
    IEnumerator PreparePipe()
    {
        yield return new WaitForSeconds(1f);
        float height = UnityEngine.Random.Range(-1f, 3f);
        transform.localPosition = new Vector3(transform.localPosition.x + 5 * pipeDistance, height, 0f);
    }
}
