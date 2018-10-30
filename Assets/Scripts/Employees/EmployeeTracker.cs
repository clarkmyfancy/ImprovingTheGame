using UnityEngine;

namespace Assets.Scripts.Employees
{
    public class EmployeeTracker : MonoBehaviour {

        public string OfficeName;
        public int OfficeId;
        public int EmployeeNum;
        public int EmployeeLimit;

    
        private UnityEngine.UI.Text _employeeCapacity;
        private OfficeController _officeCtrl;
        // Use this for initialization
        void Start () {
            
        }
	
        // Update is called once per frame
        void FixedUpdate () {
            _employeeCapacity = this.gameObject.GetComponent<UnityEngine.UI.Text>();
            _officeCtrl = GameObject.FindWithTag("OfficeTracker").GetComponent<OfficeController>();
            OfficeName = _officeCtrl.OfficeName;
            OfficeId = _officeCtrl.OfficeId;
            EmployeeNum = _officeCtrl.Office.EmployeeNum;
            EmployeeLimit = _officeCtrl.Office.EmployeeLimit;
            _employeeCapacity.text = EmployeeNum + "/" + EmployeeLimit;
        }
    }
}
