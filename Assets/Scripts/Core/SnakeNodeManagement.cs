using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnakeNodeManagement : MonoBehaviour
{
    LinkedList<CustomNode> NodeList = new LinkedList<CustomNode>();
    GameObject firstNode;
    float positionDiff = 2f;
    void Start()
    {
        firstNode = GameObject.Find("Player");
        if (firstNode == null)
        {
            Debug.LogError("Player not found!");
            return;
        }

        NodeList.AddFirst(new CustomNode { GameObject = firstNode, Name = "First" });
    }

    public void AddNode()
    {
        var newNode = Resources.Load<GameObject>("PreFabs/SnakeNode");
        var lastNode = NodeList.Last;
        var lastNodeGameObject = NodeList.Last.Value.GameObject;
        var lastPosition = lastNodeGameObject.transform.position;
        var nodePosition = new Vector3(lastPosition.x, lastPosition.y, (lastPosition.z - positionDiff));
        newNode.transform.position = nodePosition;
        newNode.name = $"SnakeNode_{NodeList.Count}";
        var newGameObject = Instantiate(newNode, nodePosition, Quaternion.identity);
        NodeList.AddAfter(lastNode, new CustomNode { GameObject = newGameObject, Name = newNode.name });
    } 

    private class CustomNode
    {
        public string Name { get; set; }
        public GameObject GameObject { get; set; }
    }
}