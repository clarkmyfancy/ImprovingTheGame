using System.Linq;
using Assets.Scripts.Objects;
using System;
using UnityEditor.Experimental.U2D;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Employees
{
    public class EmployeeDisplay : MonoBehaviour
    {
        public int ListPosition;
        public int EmployeeId;

        private int _page;
        private Office _office;
        private Employee _employee;

        

        // Use this for initialization
        void Start()
        {
            _page = 0;
            _office = new Office();
            _employee = new Employee();
        }

        // Update is called once per frame
        void Update ()
        {
            _page = GameObject.FindWithTag("EmployeePagination").GetComponent<EmployeePagination>().Page;
            EmployeeId = _page * 4 + ListPosition;
            _office = GameObject.FindWithTag("OfficeTracker").GetComponent<OfficeController>().Office;

            if (EmployeeId <= _office.EmployeeNum - 1)
            {
                _employee = _office.GetEmployee(EmployeeId);
                this.gameObject.SetActive(true);
                this.gameObject.transform.GetChild(0).GetComponent<Text>().text = _employee.Name;
                this.gameObject.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Characters/" + _employee.Portrait + "portrait");
                string income = _employee.Income() < 0 ? "-$" + _employee.Income() + "/s" : "+$" + _employee.Income() + "/s";
                this.gameObject.transform.GetChild(2).GetComponent<Text>().text = income;
            }
        }
    }
}
