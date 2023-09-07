using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMechanics : MonoBehaviour
{
    public GameObject Camera, NewCloud, Clouds;
    public Transform Cloud;
    public Vector3 CloudPos = new Vector3(0, 0, 0);
    public Vector3 LastCloudPos = new Vector3(0, 0, 0);
     public float BaseSpeed = 1f;
     public float Speed = 6f;

    void Start()
    {
        StartCoroutine(BaseCloudPlase());
        StartCoroutine(NewCloudPlase());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BaseCloudPlase()
    {
        while(true)
        {
            BaseCloudPositions();

            yield return new WaitForSeconds(BaseSpeed);
        }
    }
    private void BaseCloudPositions()
    {
        CloudPos.x = UnityEngine.Random.Range(Camera.transform.position.x + 3, Camera.transform.position.x + 8);
        CloudPos.y = UnityEngine.Random.Range(-2, 5);
        CloudPos.z = 0;
        Cloud.position = CloudPos;
        GameObject newCloud = Instantiate(
            NewCloud,
            Cloud.position,
            Quaternion.identity) as GameObject;

            newCloud.transform.SetParent(Clouds.transform);
    }
    IEnumerator NewCloudPlase()
    {
        while(true)
        {
            CloudPositions();

            yield return new WaitForSeconds(Speed);
        }
    }
    private void CloudPositions()
    {
        CloudPos.x = UnityEngine.Random.Range(LastCloudPos.x + 4,LastCloudPos.x + 10);
        CloudPos.y = -3.7f;
        CloudPos.z = 0;
        Cloud.position = CloudPos;
        GameObject newCloud = Instantiate(
            NewCloud,
            Cloud.position,
            Quaternion.identity) as GameObject;

            newCloud.transform.SetParent(Clouds.transform);
            LastCloudPos.x = CloudPos.x;
    }
}
