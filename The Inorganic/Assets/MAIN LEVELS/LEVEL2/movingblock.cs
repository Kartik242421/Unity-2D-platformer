using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingblock : MonoBehaviour

{
    float dirX, moveSpeed = 3f;
	bool moveRight = true;
  

   
    void Update()
    {
		if (transform.position.x > 8.5f)
			moveRight = false;

		if (transform.position.x < 0f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

		
        
    }
}
