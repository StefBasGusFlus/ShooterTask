using UnityEngine;

public class Player : MonoBehaviour
{
	private const float SPEED = 7;
	[SerializeField] private GameObject _bulletPrefab;
	private float _force = 1500;

	private AudioSource _audioSource;

    private void Update()
	{
		float horizontalPosition = Input.GetAxis("Horizontal") * Time.deltaTime * SPEED;
		float verticalPosition = Input.GetAxis("Vertical") * Time.deltaTime * SPEED;

		transform.position += new Vector3(horizontalPosition,verticalPosition, 0);

		if (Input.GetButtonDown("Jump"))
		{
			_audioSource = GetComponent<AudioSource>();
			_audioSource.Play();

			GameObject bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
			bullet.GetComponent<Rigidbody>().AddForce(transform.forward * _force);
		}
	}
}
