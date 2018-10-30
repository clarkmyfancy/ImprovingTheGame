using Assets.Scripts.Objects;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.Employees
{
    public class EmployeePagination : MonoBehaviour
    {
        public int Page;
        public int PageLimit;

        private Office _office;
        public GameObject EmpDisplay1;
        public EmployeeDisplay EmpDisplay2;
        public EmployeeDisplay EmpDisplay3;
        public EmployeeDisplay EmpDisplay4;
        private List<GameObject> _employeeDisplays;

        // Use this for initialization
        void Start ()
        {
            Page = 0;
            PageLimit = 0;
        }
	
        // Update is called once per frame
        void FixedUpdate ()
        {
            _office = GameObject.FindWithTag("OfficeTracker").GetComponent<OfficeController>().Office;
            PageLimit = CalculatePageLimit();
        }

        public void PrevPage()
        {
            if (Page > 0)
                Page--;
        }

        public void NextPage()
        {
            if (Page < PageLimit)
                Page++;
        }

        private int CalculatePageLimit()
        {
            int pLimit = Mathf.FloorToInt(_office.EmployeeNum / 4.0f);
            if (_office.EmployeeNum > 1 && _office.EmployeeNum % 4 == 0)
                pLimit--;
            return pLimit;
        }
    
    }
}
