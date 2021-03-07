using UnityEngine;

public class PoolManager : MonoBehaviour
{
    private static PoolPart[] pools;
    private static GameObject objectsParent;

    [System.Serializable]
    public struct PoolPart 
    {
        public string name; //имя префаба
        public PoolObject prefab; //сам префаб, как образец
        public int count; //количество объектов при инициализации пула
        public ObjectPooling ferula; //сам пул
    }
    
    
    public static void Initialize(PoolPart[] newPools) 
    {
        pools = newPools; //заполняем информацию
        objectsParent = new GameObject ();
        objectsParent.name = "Pool"; //создаем на сцене объект Pool, чтобы не заслонять иерархию
        for (int i=0; i<pools.Length; i++) 
        {
            if(pools[i].prefab!=null) 
            {  
                pools[i].ferula = new ObjectPooling(); //создаем свой пул для каждого префаба
                pools[i].ferula.Initialize(pools[i].count, pools[i].prefab, objectsParent.transform); 
                //инициализируем пул заданным количество объектов
            }
        }
    }
    
    
}
