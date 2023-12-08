using System;
using UnityEngine;
public class b4D5cr1p : MonoBehaviour {
  public float maxX; // how far can we go?
  public float maxY; public float maxZ;
  private Vector3 newPosition; // we'll move here!
  public int counter = 0; // count the moves
  private bool canMove = true; // can we move?

  void Update() {
    if (Input.GetMouseButtonDown(0)) { DoTheMove(); }
  }

  private void DoTheMove() {
    // so many randoms... what do they mean?
    if (canMove) {
      newPosition = new Vector3(
        UnityEngine.Random.value > 0.5f ? UnityEngine.Random.Range(-maxX, maxX) : transform.position.x,
        UnityEngine.Random.value > 0.5f ? UnityEngine.Random.Range(-maxY, maxY) : transform.position.y,
        UnityEngine.Random.value > 0.5f ? UnityEngine.Random.Range(-maxZ, maxZ) : transform.position.z
      );
      transform.position = newPosition; // go there!
      Debug.Log("We moved!"); // we moved!!!
      counter++; // up the count
      if (counter > 10) canMove = false; // stop moving after 10
    }
    else { Debug.LogWarning("Can't move anymore!"); }
  }

  public void ResetCounter() {
    counter = 0; // back to 0
    canMove = true; // we can move again
  }
}
