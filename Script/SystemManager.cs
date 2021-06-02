using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    static SystemManager intance=null;

    public static SystemManager Instance
    {
        get
        {
            return intance;
        }

    }

    [SerializeField]
    Player player;

    public Player Hero
    {
        get
        {
            return player;
        } 
    }

    /*
    [SerializeField]
    Enemy enemy;

    public Enemy Enemy
    {
        get
        {
            return enemy;
        }
    }
    */
    [SerializeField]
    EnemyManager enemyManager;

    public EnemyManager EnemyManager
    {
        get
        {
            return enemyManager;
        }
    }



    [SerializeField]
    BulletManager bulletManager;

    public BulletManager BulletManager
    {
        get
        {
            return bulletManager;
        }
    }


    GamePointAccumulator gamePointAccumulator = new GamePointAccumulator();

    public GamePointAccumulator GamePointAccumulator
    {
        get
        {
            return gamePointAccumulator;
        }
    }


    [SerializeField]
    EffectManager effectManager;

    public EffectManager EffectManager
    {
        get
        {
            return effectManager;
        }
    }

   
    


    PrefabCacheSystem enemyCacheSystem = new PrefabCacheSystem();
    public PrefabCacheSystem EnemyCacheSystem
    {
        get
        {
            return enemyCacheSystem;
        }
    }

    PrefabCacheSystem bulletCacheSystem = new PrefabCacheSystem();
    public PrefabCacheSystem BulletCacheSystem
    {
        get
        {
            return bulletCacheSystem;
        }
    }

    PrefabCacheSystem effectCacheSystem = new PrefabCacheSystem();
    public PrefabCacheSystem EffectCacheSyste
    {
        get
        {
            return effectCacheSystem;
        }
    }

    private void Awake()
    {
        if (intance != null)
        { 
            Debug.LogError("SystemManager error! Singletone error!");
            Destroy(gameObject);
            return;
        }

        intance = this;
    }

   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
