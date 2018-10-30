using UnityEngine;

namespace Assets.Scripts.Employees
{
    public class SetEmployeeActivity : MonoBehaviour
    {
        public int EmployeeNumber;
        public GameObject Employee;

        private OfficeController _office;

        // Use this for initialization
        void Start ()
        {
            _office = GameObject.FindWithTag("OfficeTracker").GetComponent<OfficeController>();
        }
	
        void FixedUpdate ()
        {
            Employee.SetActive(EmployeeNumber <= _office.Office.EmployeeNum);
        }
    }
}
