using UnityEngine;

public class GenerateCoinRandomly : MonoBehaviour
{
    private int CoinMaxCount = 20;

    private GameObject prefabToInstantiate;

    private float locationXMin = -48f;
    private float locationXMax = 48f;
    private float locationZMin = -490f;
    private float locationZMax = 490;
    private int CoinCounter = 0;

    void Start()
    {
        prefabToInstantiate = Resources.Load<GameObject>("PreFabs/Coin");
        if (prefabToInstantiate == null)
        {
            Debug.LogError("Prefab not found. Make sure it exists in the Resources folder.");
            return;
        }
    }

    void Update()
    {
        if (CoinCounter < CoinMaxCount)
        { 
            Vector3 randomPosition = new Vector3(
                    Random.Range(locationXMin, locationXMax),
                    10,
                    Random.Range(locationZMin, locationZMax)
                );
            GameObject instantiatedObject = Instantiate(prefabToInstantiate, randomPosition, Quaternion.identity);
            CoinCounter++;
            instantiatedObject.name = $"GeneratedCoin_{CoinCounter}";
        } 
    }
}
