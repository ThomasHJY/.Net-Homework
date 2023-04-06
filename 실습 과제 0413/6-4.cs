using System;

namespace First_Net
{
    /* 음식 주문 시스템 클래스, 속성, 오버로딩
       속성 : 주문번호, 주문자명, 주문일자, 주문메뉴, 수량, 가격, 주소, 전화번호 등
       메서드 : 메뉴선택, 수량 입력, 가격 계산, 주문 생성, 결제, 배송 등 */
    class FoodOrder
    {
        private static int countOfOrder;

        private string ordererName;
        private string orderDate;
        private string address;
        private string phoneNumber;
        private string[] orderName;
        private int orderNumber;
        private int[] orderAmount;
        private double[] orderPrice;

        private static int CountOfOrder
        {
            get
            {
                return countOfOrder;
            }
            set
            {
                if (value > 0)
                {
                    countOfOrder = value;
                }
            }
        }

        public string OrdererName
        {
            get
            {
                return ordererName;
            }
            set
            {
                ordererName = value;
            }
        }
        public string OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
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
        public string[] OrderName
        {
            get
            {
                return orderName;
            }
            set
            {
                orderName = value;
            }
        }
        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }
            set
            {
                if (value > 0)
                {
                    orderNumber = value;
                }
            }
        }
        public int[] OrderAmount
        {
            get
            {
                return orderAmount;
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
                
                if(positive)
                {
                    orderAmount = value;
                }
            }
        }
        public double[] OrderPrice
        {
            get
            {
                return orderPrice;
            }
            set
            {
                bool positive = true;

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 0)
                    {
                        positive = false;
                        break;
                    }
                }

                if (positive)
                {
                    orderPrice = value;
                }
            }
        }

        public void CreateOrder()
        {
            OrderNumber = ++CountOfOrder;
            Console.WriteLine("{0}번째 주문입니다.", OrderNumber);
        }
        public void InputOrderAmount(int amount)
        {
            OrderAmount = new int[] { amount };
        }
        public void InputOrderAmount(int[] amount) //오버로딩
        {
            OrderAmount = amount;
        }
        public void CalcPrice(double price)
        {
            OrderPrice = new double[] { price };
        }
        public void CalcPrice(double[] price) //오버로딩
        {
            OrderPrice = price;
        }
        public void PayOrder()
        {
            Console.WriteLine("결제 진행하겠습니다.");
        }
        public void DeliverOrder(string address)
        {
            Address = address;
            Console.WriteLine("{0} 배달 진행 하겠습니다.", Address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("과제 6-4");
        }
    }
}