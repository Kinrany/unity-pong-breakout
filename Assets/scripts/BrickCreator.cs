using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCreator : MonoBehaviour {

	public int GridWidth;
	public int GridHeight;

	public GameObject BrickPrefab;

	const float BRICK_OFFSET_HORIZONTAL = 0.6f;
	const float BRICK_OFFSET_VERTICAL = 1.1f;

	void Start() {
		float GRID_OFFSET_HORIZONTAL = (GridWidth - 1) * BRICK_OFFSET_HORIZONTAL / 2;
		float GRID_OFFSET_VERTICAL = (GridHeight - 1) * BRICK_OFFSET_VERTICAL / 2;

		for (int ih = 0; ih < GridWidth; ++ih) {
			for (int iv = 0; iv < GridHeight; ++iv) {
				var brick = Instantiate(BrickPrefab, transform);
				float x = ih * BRICK_OFFSET_HORIZONTAL - GRID_OFFSET_HORIZONTAL;
				float y = iv * BRICK_OFFSET_VERTICAL - GRID_OFFSET_VERTICAL;
				brick.transform.position = new Vector3(x, y, 0);
			}
		}
	}
}