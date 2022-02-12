using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayRollService_ADO.NET;

namespace TestProjectForEmployeePayRoll
{
    [TestClass]
    public class PayrollServiceTesting
    {
        EmployeeRepository employeeRepository;
        ERRepository eRRepository;
        TransactionClass transactionClas;
        [TestInitialize]
        public void SetUp()
        {
            employeeRepository = new EmployeeRepository();
            eRRepository = new ERRepository();
        }

        //Usecase 3: Update basic pay in Sql Server
        [TestMethod]
        [TestCategory("Using Sql Query")]
        public void GivenUpdateQuery_ReturnOne()
        {
            int expected = 1;
            int actual = employeeRepository.UpdateSalaryQuery();
            Assert.AreEqual(actual, expected);
        }
        //Usecase 4: Update basic pay in Sql Server using Stored Procedure
        [TestMethod]
        [TestCategory("Using Stored Procedure")]
        public void GivenUpdateQuery_UsingStoredProcedure_ReturnOne()
        {
            EmployeeDataManager employeeDataManager = new EmployeeDataManager();
            int expected = 1;
            employeeDataManager.EmployeeID = 3;
            employeeDataManager.EmployeeName = "shaif";
            employeeDataManager.BasicPay = 3900989;
            int actual = employeeRepository.UpdateSalary(employeeDataManager);
            Assert.AreEqual(actual, expected);
        }

    }
