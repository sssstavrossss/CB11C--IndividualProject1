using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartA
{
    class Assignment
    {
        private int _id;
        public int ID { get { return _id; } private set { } }

        private string _title;
        public string Title { get { return _title; } private set { } }

        private string _description;
        public string Description { get { return _description; } private set { } }

        private DateTime _subDateTime;
        public DateTime SubDateTime { get { return _subDateTime; } private set { } }

        private int _oralMark;
        public int OralMark { get { return _oralMark; } private set { } }

        private int _totalMark;
        public int TotalMark { get { return _totalMark; } private set { } }

        public Assignment()
        {
            this._id = getID();
            this._title = Helper.getString("assignment title");
            this._description = Helper.getString("assignment description");
            this._subDateTime = Helper.getDate("assignment submission date").Date;
            this._oralMark = Helper.getNumber("assignment oral mark");
            this._totalMark = Helper.getNumber("assignment total mark");
        }

        public Assignment(string _title, string _description, DateTime _subDateTime, int _oralMark, int _totalMark)
        {
            this._id = getID();
            this._title = _title;
            this._description = _description;
            this._subDateTime = _subDateTime.Date;
            this._oralMark = _oralMark;
            this._totalMark = _totalMark;
        }

        private int getID()
        {
            if (ObjectLists.Assignments.Count > 0)
            {
                return ObjectLists.Assignments.Count + 1;
            }
            else
            {
                return 1;
            }
        }

    }
}
