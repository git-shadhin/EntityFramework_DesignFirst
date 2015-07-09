using EntityFramework_DesignFirst.DAL;
using EntityFramework_DesignFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkDemo
{
    public partial class EmployeeDetailsDemo : System.Web.UI.Page
    {
        EmployeeRepository empRepo = new EmployeeRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                grdEmployeeBind();
                ddlDepartmentBind();
            }
        }

        private void ddlDepartmentBind() 
        {
            ddlDepartment.DataSource = empRepo.GetDepartment();
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "ID";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, "--select--");
        }

        private void grdEmployeeBind()
        {
            grdEmployee.DataSource = empRepo.GetEmployee();
            grdEmployee.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Gender = rblGender.SelectedItem.Text;
            emp.DepartmentId = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
            emp.Salary = Convert.ToInt32(txtSalary.Text);

            empRepo.InsertEmployeeDetail(emp); // add employee informations using stored procedure
            grdEmployeeBind();

            ResetControls();
        }

        private void ResetControls()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            ddlDepartment.ClearSelection();
        }
    }
}