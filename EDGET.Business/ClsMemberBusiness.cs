using EDGET.DataAccess;
using System;
using System.Data;

namespace EDGET.Business
{
    public class ClsMemberBusiness
    {
        private enum enMode { New = 0, Update = 1 }
        private enMode _Mode = enMode.New;

        public int MemberID { get; set; }
        public int PersonID { get; set; }

        public ClsPersonBusiness PersonInfo
        {
            get { return ClsPersonBusiness.GetPersonByID(PersonID); }
        }

        public string StudentID { get; set; }
        public string Department { get; set; }
        public int YearOfStudy { get; set; }
        public DateTime JoinDate { get; set; }
        public bool Status { get; set; }
        public bool IsExecuted { get; set; }

        public ClsMemberBusiness()
        {
            MemberID = -1;
            PersonID = -1;
            StudentID = string.Empty;
            Department = string.Empty;
            YearOfStudy = 0;
            JoinDate = DateTime.MinValue;
            Status = false;
            IsExecuted = false;
            _Mode = enMode.New;
        }

        public ClsMemberBusiness(int memberID, int personID, string studentID, string department, int yearOfStudy, DateTime joinDate, bool status)
        {
            MemberID = memberID;
            PersonID = personID;
            StudentID = studentID;
            Department = department;
            YearOfStudy = yearOfStudy;
            JoinDate = joinDate;
            Status = status;
            IsExecuted = true;
            _Mode = enMode.Update;
        }

        public static DataTable GetAllMembers()
        {
            return ClsMemberDataAccess.GetAllMembers();
        }

        public static ClsMemberBusiness GetMemberByID(int memberID)
        {
            int personID = -1;
            string studentID = string.Empty;
            string department = string.Empty;
            int yearOfStudy = 0;
            DateTime joinDate = DateTime.MinValue;
            bool status = false;

            if (ClsMemberDataAccess.GetMemberByID(memberID, ref personID, ref studentID, ref department, ref yearOfStudy, ref joinDate, ref status))
            {
                return new ClsMemberBusiness(memberID, personID, studentID, department, yearOfStudy, joinDate, status);
            }

            return null;
        }

        private bool AddNewMember()
        {
            int ID = ClsMemberDataAccess.AddMember(PersonID, StudentID, Department, YearOfStudy, JoinDate, Status);

            if (ID != -1)
            {
                MemberID = ID;
                _Mode = enMode.Update;
                return true;
            }

            return false;
        }

        private bool UpdateMember()
        {
            return ClsMemberDataAccess.UpdateMember(MemberID, PersonID, StudentID, Department, YearOfStudy, JoinDate, Status);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.New:
                    return AddNewMember();

                case enMode.Update:
                    return UpdateMember();

                default:
                    return false;
            }
        }

        public bool DeleteMember(int memberID)
        {
            return ClsMemberDataAccess.DeleteMember(memberID);
        }
    }
}
