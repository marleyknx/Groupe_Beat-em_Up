using UnityEngine;

public interface IHitable {

    float LastHitTime {get; set;}
    void TakeHit(GameObject hitSource);
}