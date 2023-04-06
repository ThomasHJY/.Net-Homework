/*아래 클래스에 대해 속성과 메서드를 정의하고 간단한 프로그램을 작성하시오. (아래 클래스 모두 구현)
호텔 예약 클래스, 게시판 클래스, 음악 재생 시스템 클래스, 주식 투자 시뮬레이션 클래스
속성, 오버로딩 추가*/

using System;

namespace First_Net
{
    class HotelReservation
    /* 호텔 예약 클래스 
       속성 : 예약번호, 예약자명, 예약일자, 예약메뉴, 가격, 전화번호
       메서드 : 예약 생성, 주문 취소, 결제*/
    {
        private static int countOfReserve;

        private string reserverName;
        private string reservationDate;
        private string phoneNumber;
        private string[] roomName;
        private int reservationNumber;
        private double[] roomPrice;

        private static int CountOfReserve
        {
            get
            {
                return countOfReserve;
            }
            set
            {
                if (value > 0)
                {
                    countOfReserve = value;
                }
            }
        }

        public string ReserverName
        {
            get
            {
                return reserverName;
            }
            set
            {
                reserverName = value;
            }
        }
        public string ReservationDate
        {
            get
            {
                return reservationDate;
            }
            set
            {
                reservationDate = value;
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
        public string[] RoomName
        {
            get
            {
                return roomName;
            }
            set
            {
                roomName = value;
            }
        }
        private int ReservationNumber
        {
            get
            {
                return reservationNumber;
            }
            set
            {
                if (value > 0)
                {
                    reservationNumber = value;
                }
            }
        }
        public double[] RoomPrice
        {
            get
            {
                return roomPrice;
            }
            set
            {
                bool positive = true;
                for(int i = 0; i < value.Length; i++)
                {
                    if(value[i] < 0)
                    {
                        positive = false;
                        break;
                    }
                }

                if (positive)
                {
                    roomPrice = value;
                }
            }
        }

        public void CreateReservation()
        {
            ReservationNumber = ++CountOfReserve;
            Console.WriteLine("{0}번째 예약입니다.", ReservationNumber);
        }
        public void CancelReservation()
        {
            if (ReservationNumber > 0)
            {
                CountOfReserve--;
                ReservationNumber = 0;
                Console.WriteLine("예약이 취소됐습니다.");
            }
            else
            {
                Console.WriteLine("취소 가능한 예약이 없습니다.");
            }
        }
        public void PayReservation()
        {
            for (int i = 0; i < RoomName.Length; i++)
            {
                Console.WriteLine("방: {0}, 가격: {1} 결제 진행하겠습니다.", RoomName[i], RoomPrice[i]);
            }
        }
        public void PayReservation(double discount) //overloading
        {
            for (int i = 0; i < RoomName.Length; i++)
            {
                Console.WriteLine("방: {0}, 가격: {1} - {2} = {3} 결제 진행하겠습니다.", 
                    RoomName[i], RoomPrice[i], discount, RoomPrice[i] - discount);
            }
        }
    }

    class BulletinBoard
    /* 게시판 클래스 
       속성 : 글번호, 작성자명, 작성일자, 작성내용, 카테고리
       메서드 : 글 작성, 글 삭제, 글 검색*/
    {
        private static int countOfPost;

        private int postNumber;
        private string posterName;
        private string postDate;
        private string postContent;
        private string[] category;

        private static int CountOfPost
        {
            get
            {
                return countOfPost;
            }
            set
            {
                if (value > 0)
                {
                    countOfPost = value;
                }
            }
        }

        public int PostNumber
        {
            get
            {
                return postNumber;
            }
            set
            {
                if (value > 0)
                {
                    postNumber = value;
                }
            }
        }

        public string PosterName
        {
            get
            {
                return posterName;
            }
            set
            {
                posterName = value;
            }
        }
        public string PostDate
        {
            get
            {
                return postDate;
            }
            set
            {
                postDate = value;
            }
        }
        public string PostContent
        {
            get
            {
                return postContent;
            }
            set
            {
                postContent = value;
            }
        }
        public string[] Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public void Post()
        {
            PostNumber = ++CountOfPost;
            Console.WriteLine("{0}번째 글입니다.", PostNumber);
        }
        public void Delite()
        {
            if (PostNumber > 0)
            {
                CountOfPost--;
                PostNumber = 0;
                Console.WriteLine("글이 삭제됐습니다.");
            }
            else
            {
                Console.WriteLine("삭제 가능한 글이 없습니다.");
            }
        }
        public void SearchContent(string s)
        {
            Console.WriteLine("검색 결과입니다.");
        }
        public void SearchContent(string s, int index) //overloading
        {
            Console.WriteLine("카테고리 \"{0}\"에서 검색하기", Category[index]);
            Console.WriteLine("검색 결과입니다.");
        }
    }

    class MusicPlayer
    /* 음악 재생 시스템 클래스 
       속성 : 음악번호, 음악 이름, 재생 상태, 카테고리
       메서드 : 음악 추가, 음악 삭제, 음악 재생, 음악 정지, 음악 검색*/
    {
        private static int countOfMusic;

        private bool playingMusic;
        private int musicNumber;
        private string musicName;
        private string[] category;

        private static int CountOfMusic
        {
            get
            {
                return countOfMusic;
            }
            set
            {
                if (value > 0)
                {
                    countOfMusic = value;
                }
            }
        }
        public bool PlayingMusic
        {
            get
            {
                return playingMusic;
            }
            set
            {
                playingMusic = value;
            }
        }
        public int MusicNumber
        {
            get
            {
                return musicNumber;
            }
            set
            {
                if (value > 0)
                {
                    musicNumber = value;
                }
            }
        }
        public string MusicName
        {
            get
            {
                return musicName;
            }
            set
            {
                musicName = value;
            }
        }
        public string[] Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public void AddMusic()
        {
            MusicNumber = ++CountOfMusic;
            Console.WriteLine("{0}번째 음악입니다.", MusicNumber);
        }
        public void DeliteMusic()
        {
            if (MusicNumber > 0)
            {
                CountOfMusic--;
                MusicNumber = 0;
                Console.WriteLine("음악이 삭제됐습니다.");
            }
            else
            {
                Console.WriteLine("삭제 가능한 음악이 없습니다.");
            }
        }
        public void PlayMusic()
        {
            PlayingMusic = true;
            Console.WriteLine("음악을 재생합니다.");
        }
        public void StopMusic()
        {
            PlayingMusic = false;
            Console.WriteLine("음악을 정지합니다.");
        }
        public void SearchMusic(string s)
        {
            Console.WriteLine("검색 결과입니다.");
        }
        public void SearchMusic(string s, int index) //overloading
        {
            Console.WriteLine("카테고리 \"{0}\"에서 검색하기", Category[index]);
            Console.WriteLine("검색 결과입니다.");
        }
    }

    class StockInvestment
    /* 주식 투자 시뮬레이션 클래스
       속성 : 주식번호, 투자자명, 투자일자, 주식이름, 가격;
       메서드 : 매수, 매도, 가격 검색*/
    {
        private static int countOfStock;
        
        private int stockNumber;
        private double stockPrice;
        private string investorName;
        private string investmentDate;
        private string stockName;

        private static int CountOfStock
        {
            get
            {
                return countOfStock;
            }
            set
            {
                if (value > 0)
                {
                    countOfStock = value;
                }
            }
        }
        public int StockNumber
        {
            get
            {
                return stockNumber;
            }
            set
            {
                if (value > 0)
                {
                    stockNumber = value;
                }
            }
        }
        public double StockPrice
        {
            get
            {
                return stockPrice;
            }
            set
            {
                if (value > 0)
                {
                    stockPrice = value;
                }
            }
        }
        public string InvestorName
        {
            get
            {
                return investorName;
            }
            set
            {
                investorName = value;
            }
        }
        public string InvestmentDate
        {
            get
            {
                return investmentDate;
            }
            set
            {
                investmentDate = value;
            }
        }
        public string StockName
        {
            get
            {
                return stockName;
            }
            set
            {
                stockName = value;
            }
        }

        public void BuyStock()
        {
            StockNumber = ++CountOfStock;
            Console.WriteLine("매수 완료");
        }
        public void SellStock()
        {
            if (StockNumber > 0)
            {
                CountOfStock--;
                StockNumber = 0;
                Console.WriteLine("매도 완료.");
            }
            else
            {
                Console.WriteLine("판매 가능한 주식이 없습니다.");
            }
        }
        public void SearchStockPrice()
        {
            Console.WriteLine("{0}의 가격: {1}", StockName, StockPrice);
        }
        public void SearchStock(bool all) //overloading
        {
            if (all)
            {
                Console.WriteLine("{0}님의 모든 주식 가격 출력합니다.", investorName);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("과제 6-5");
        }
    }
}