using System;

namespace First_Net
{
    /* 학생 클래스, 속성, 오버로딩
       속성 : 이름, 학번, 전공, 학년, 성적, 출석률, 이메일, 전화번호 등
       메서드 : 출석체크, 성적입력, 성적조회, 이메일발송, 전화걸기 등 */
    class Student
    {
        private string studentName;
        private string studentNumber;
        private string major;
        private string email;
        private string phoneNumber;
        private int grade;
        private int classCount;
        private int attendCount;
        private double attendanceRate;
        private double score;

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value > 0)
                {
                    grade = value;
                }
            }
        }
        public int ClassCount
        {
            get
            {
                return classCount;
            }
            set
            {
                if (value > 0)
                {
                    classCount = value;
                }
            }
        }
        public int AttendCount
        {
            get
            {
                return attendCount;
            }
            set
            {
                if (value > 0)
                {
                    attendCount = value;
                }
            }
        }
        public double AttendanceRate
        {
            get
            {
                return attendanceRate;
            }
            set
            {
                if (value > 0)
                {
                    attendanceRate = value;
                }
            }
        }
        public double Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value > 0)
                {
                    score = value;
                }
            }
        }

        public void CheckAttendance()
        {
            ClassCount++;
            AttendCount++;
            AttendanceRate = AttendCount / ClassCount * 100;

            Console.WriteLine("출석 체크 완료");
        }
        public void CheckAttendance(bool attend) //overloading
        {
            if (attend)
            {
                ClassCount++;
                AttendCount++;
                AttendanceRate = AttendCount / ClassCount * 100;

                Console.WriteLine("출석 체크 완료");
            }
            else
            {
                ClassCount++;
                AttendanceRate = AttendCount / ClassCount * 100;

                Console.WriteLine("결석 체크 완료");
            }
        }
        public void InputScore(double s)
        {
            Score = s;
        }
        public void CheckScore()
        {
            Console.WriteLine("{0}", Score);
        }
        public void SendEmail(string content)
        {
            Console.WriteLine("{0}(으)로 {1}을(를) 보냅니다.", Email, content);
        }
        public void PhoneCall()
        {
            Console.WriteLine("{0}(으)로 전화합니다.", PhoneNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("과제 6-3");
        }
    }
}