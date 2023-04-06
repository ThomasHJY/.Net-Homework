using System;

namespace First_Net
{
    /* 주문 클래스, 속성 적용, 메소드 오버로딩 추가
       속성 : 주문번호, 주문자명, 주문일자, 주문상품, 수량, 가격, 주소, 전화번호 등
       메서드 : 주문생성, 주문취소, 결제, 배송 등 */
    class Order
    {
        private static int countOfOrder;

        private string ordererName;
        private string orderDate;
        private string orderName;
        private string address;
        private string phoneNumber;
        private int orderNumber;
        private int orderAmount;
        private double orderPrice;

        private static int CountOfOrder
        {
            get
            {
                return countOfOrder;
            }
            set
            {
                if(value > 0)
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
        public string OrderName
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
        public int OrderAmount
        {
            get
            {
                return orderAmount;
            }
            set
            {
                if (value > 0)
                {
                    orderAmount = value;
                }
            }
        }
        public double OrderPrice
        {
            get
            {
                return orderPrice;
            }
            set
            {
                if (value > 0)
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
        public void CancelOrder()
        {
            if (OrderNumber > 0)
            {
                CountOfOrder--;
                OrderNumber = 0;
                Console.WriteLine("주문이 취소 됐습니다.");
            }
            else
            {
                Console.WriteLine("취소 가능한 주문이 없습니다.");
            }
        }
        public void PayOrder(double oPrice)
        {
            OrderPrice = oPrice;
            OrderAmount = 1;
            Console.WriteLine("수량: {0}, 가격: {1} 결제 진행됐습니다.", OrderAmount, OrderPrice);
        }
        public void PayOrder(double oPrice, int oAmount) //overloading
        {
            OrderPrice = oPrice * oAmount;
            OrderAmount = oAmount;
            Console.WriteLine("수량: {0}, 가격: {1} 결제 진행됐습니다.", OrderAmount, OrderPrice);
        }
        public void DeliverOrder(string address)
        {
            Address = address;
            Console.WriteLine("{0}(으)로 배달 진행하겠습니다.", Address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("과제 6-2");
        }
    }
}