using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    class Course
    {

        private int _id = 1;
        public int ID { get { return _id; } private set { } }

        private string _title; 
        public string Title { get { return _title; } private set { } }

        private string _stream; 
        public string Stream { get { return _stream; } private set { } }

        private string _type;
        public string Type { get { return _type; } private set { } }

        private DateTime _startDate;
        public DateTime StartDate { get { return _startDate; } private set { } }

        private DateTime _endDate; 
        public DateTime EndDate { get { return _endDate; } private set { } }

        private List<int> _courseStudents = new List<int>();
        public List<int> CourseStudents { get { return _courseStudents; } private set { } }

        private List<int> _courseAssignments = new List<int>();
        public List<int> CourseAssignments { get { return _courseAssignments; } private set { } }

        private List<int> _courseTrainers = new List<int>();
        public List<int> CourseTrainers { get { return _courseTrainers; } private set { } }

        public Course()
        {

            this._id = getID();
            this._title = Helper.getString("course title");
            this._stream = Helper.getString("course stream");
            this._type = Helper.getString("course type");
            this._startDate = Helper.getDate("date of course start date").Date;
            this._endDate = Helper.getDate("date of course end date").Date;

        }

        public Course(string _title, string _stream, string _type, DateTime _startDate, DateTime _endDate)
        {

            this._id = getID();
            this._title = _title;
            this._stream = _stream;
            this._type = _type;
            this._startDate = _startDate.Date;
            this._endDate = _endDate.Date;

        }

        private int getID()
        {
            if (ObjectLists.Courses.Count > 0)
            {
                return ObjectLists.Courses.Count+1;
            }
            else
            {
                return 1;
            }
        }

    }
}
