using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    class People
    {
        protected int _id;
        public int ID { get { return _id; } private set { } }

        private string _lastName;
        public string LastName { get { return _lastName; } private set { } }

        private string _firstName;
        public string FirstName { get { return _firstName; } private set { } }

        protected People()
        {
            this._lastName = Helper.getString("last name");
            this._firstName = Helper.getString("first name");
        }

        protected People(string _lastName, string _firstName)
        {
            this._lastName = _lastName;
            this._firstName = _firstName;
        }

    }

    class Student : People
    {

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth { get { return _dateOfBirth; } private set { } }

        private int _tuitionFees;
        public int TuitionFees { get { return _tuitionFees; } private set { } }

        private List<int> _studentAssignments = new List<int>();
        public List<int> StudentAssignments { get { return _studentAssignments; } private set { } }

        public Student()
        {
            this._id = getID();
            this._dateOfBirth = Helper.getDate("date of birth of student").Date;
            this._tuitionFees = Helper.getNumber("tuituin fees of student");
        }
        public Student(string _lastName, string _firstName, DateTime _dateOfBirth, int _tuitionFees) : base(_lastName, _firstName)
        {
            this._id = getID();
            this._dateOfBirth = _dateOfBirth.Date;
            this._tuitionFees = _tuitionFees;
        }
        private int getID()
        {
            if (ObjectLists.Students.Count > 0)
            {
                return ObjectLists.Students.Count+1;
            } else
            {
                return 1;
            }
        }
    }

    class Trainer : People
    {
        private string _subject;
        public string Subject { get { return _subject; } private set { } }

        public Trainer()
        {
            this._id = getID();
            this._subject = Helper.getString("trainer's subject");
        }
        public Trainer(string _firstName, string _lastName, string _subject) : base(_lastName, _firstName) 
        {
            this._id = getID();
            this._subject = _subject;
        }

        private int getID()
        {
            if (ObjectLists.Trainers.Count > 0)
            {
                return ObjectLists.Trainers.Count+1;
            }
            else
            {
                return 1;
            }
        }
    }

}
