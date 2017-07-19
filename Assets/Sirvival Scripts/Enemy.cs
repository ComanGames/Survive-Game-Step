using UnityEngine;

namespace Assets
{
    public class Enemy:MonoBehaviour
    {
        public float RotationSpeed = 10f;
        public float MovingSpeed = 1f;
        public Transform FollowTo;
        private Rigidbody _body;
        public void Start()
        {
            _body =gameObject.GetComponent<Rigidbody>();
        }
        public void Update()
        {
            var lookPos = FollowTo.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * RotationSpeed);
        }

        public void FixedUpdate()
        {
            Vector3 velocity = transform.forward * Time.fixedDeltaTime * MovingSpeed;
            velocity.y = _body.velocity.y;
            _body.velocity= velocity;

        }
    }
}