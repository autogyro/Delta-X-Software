using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // Start is called before the first frame update
    class Object
    {
        public Object(string name, GameObject obj)
        {
            Name = name;
            Instance = obj;
            Instance.name = Name;
        }

        public void ChangePosition(Vector3 position)
        {
            Instance.transform.localPosition = position;
        }

        public void ChangeSize(Vector3 size)
        {
            Instance.transform.localScale = size;
        }

        public bool IsName(string n)
        {
            if (Name == n)
                return true;
            return false;
        }

        string Name = "obj";
        Vector3 Size;
        Vector3 Position;
        public GameObject Instance;
    }

    List<Object> ObjectList;

    public static ObjectManager instance = null;
    public GameObject Product;

    Vector3 DeltaPosition;

    void Awake()
    {
        instance = this;
    }

    static public ObjectManager GetInstance()
    {
        if (instance == null)
            instance = new ObjectManager();

        return instance;
    }

    void Start()
    {
        ObjectList = new List<Object>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RenderObjects()
    {

    }

    public void UpdateObject(string name, Vector3 size, Vector3 position)
    {
        // if not exit, creat one
        
        if (!IsObjectExit(name))
        {
            Debug.Log(name);
            GameObject newObject = Instantiate(Product, position, Quaternion.identity);
            newObject.transform.SetParent(this.transform);
            newObject.SetActive(true);
            newObject.transform.localScale = size;
            Object obj = new Object(name, newObject);

            ObjectList.Add(obj);
        }

        for(int i = 0; i < ObjectList.Count; i++)
        {
            if (ObjectList[i].IsName(name))
            {
                ObjectList[i].ChangePosition(position);
                ObjectList[i].ChangeSize(size);
            }
        }
    }

    public void DeleteObject(string name)
    {
        for (int i = 0; i < ObjectList.Count; i++)
        {
            if (ObjectList[i].IsName(name))
            {
                Destroy(ObjectList[i].Instance);
                ObjectList.RemoveAt(i);
                return;
            }
        }
    }

    bool IsObjectExit(string name)
    {
        foreach (var obj in ObjectList)
        {
            if (obj.IsName(name))
                return true;
        }

        return false;
    }
}
