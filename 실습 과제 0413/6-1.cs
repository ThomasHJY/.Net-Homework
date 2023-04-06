using System;

namespace First_Net
{
    /* 컴퓨터 클래스, 속성 적용, 메소드 오버로딩 추가
       속성 : 브랜드, 모델, 용도, 운영체제, 메모리 용량, 저장 용량, 화면 크기 등
       메서드 : on, off, 재부팅, 프로그램 실행, 파일 저장, 인터넷 연결 등 */
    class Computer
    {
        private string brand;
        private string model;
        private string purpose;
        private string os;
        private int mainMemoryCapacity;
        private int secondaryMemoryCapacity;
        private double monitorSize;

        public string Brand 
        { 
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Purpose
        {
            get
            {
                return purpose;
            }
            set
            {
                purpose = value;
            }
        }
        public string Os
        {
            get
            {
                return os;
            }
            set
            {
                os = value;
            }
        }
        public int MainMemoryCapacity 
        { 
            get
            {
                return mainMemoryCapacity;
            }
            set
            {
                if(value > 0)
                {
                    mainMemoryCapacity = value;
                }
            }
        }
        public int SecondaryMemoryCapacity
        {
            get
            {
                return secondaryMemoryCapacity;
            }
            set
            {
                if (value > 0)
                {
                    secondaryMemoryCapacity = value;
                }
            }
        }
        public double MonitorSize
        {
            get
            {
                return monitorSize;
            }
            set
            {
                if (value > 0)
                {
                    monitorSize = value;
                }
            }
        }

        public void On()
        {
            Console.WriteLine("컴퓨터가 켜졌습니다.");
        }
        public void Off()
        {
            Console.WriteLine("컴퓨터가 꺼졌습니다.");
        }
        public void Reboot()
        {
            Console.WriteLine("컴퓨터가 재부팅 됐습니다.");
        }
        public void RunProgram(string programName)
        {
            Console.WriteLine("{0}을(를) 실행합니다.", programName);
        }
        public void SaveFile(string fileName)
        {
            Console.WriteLine("{0}을(를) 저장합니다.", fileName);
        }
        public void SaveFile(string fileName, string newName) //overloading
        {
            Console.WriteLine("{0}을(를) {1}(으)로 저장합니다.", fileName, newName);
        }
        public void ConnectInternet()
        {
            Console.WriteLine("인터넷에 연결합니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("과제 6-1");
        }
    }
}