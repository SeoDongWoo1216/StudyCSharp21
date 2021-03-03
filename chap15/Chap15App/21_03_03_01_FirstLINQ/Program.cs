using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_03_01_FirstLINQ
{
    // LINQ 예제
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star  { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            // LINQ 안쓰는 방식

            //List<int> result = new List<int>();
            //foreach (var item in numbers)
            //{
            //    if(item % 2 == 0)
            //    {
            //        result.Add(item);
            //    }
            //}
            // result.Sort();


            // LINQ 쓰는 방식
            var result = from    item in numbers
                         where   item % 2 == 0
                         orderby item
                         select  item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }
            Console.WriteLine();


            List<Profile> profiles = new List<Profile>    // 밑의 초기화를 간단히 만듬
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하동훈", Height = 170 }
            };

            //List<Profile> profiles = new List<Profile>();
            //profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            //profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            //profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            //profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            //profiles.Add(new Profile() { Name = "하동훈", Height = 170 });


            // 내부 조인
            List<Product> products = new List<Product>
            {
                new Product(){Title = "비트",      Star = "정우성"},
                new Product(){Title = "CF 다수",   Star = "김태희"},
                new Product(){Title = "아이리스",  Star = "김태희"},
                new Product(){Title = "모래시계",  Star = "고현정"},
                new Product(){Title = "Solo 예찬", Star = "이문세"}
            };



            // LINQ 
            var resProfiles = from    item in profiles
                              where   item.Height < 175
                              orderby item.Height
                              select new
                              {
                                  // 임시 객체 생성
                                  item.Name,
                                  item.Height,
                                  InchHeight = item.Height * 0.393   // cm를 inch로 변환
                              };
                              //select item;


            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name},{item.Height}inch");
            }
            Console.WriteLine();


            /////////////////////////////////////////////////////////////////////////////////

            var resProfiles2 = from item in profiles
                               where item.Height < 175
                               orderby item.Height
                               select item.Height;  // 객체, 값만 사용했을때의 차이점을 기억해두자.

            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();


            /////////////////////////////////////////////////////////////////////////////////

            // group by 사용
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g  // group by로 T/F로 그룹을 나눔.
                               select new
                               {
                                   GroupKey = g.Key, Items = g  
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");
                foreach (var item in group.Items)
                {
                    Console.WriteLine($"{item.Name}, {item.Height}cm");
                }
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////

            // 내부 조인 사용
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   InchHeight = p.Height * 0.393,
                               };

            Console.WriteLine("내부조인 결과!");

            // 이너조인과 같은 원리로, 작품이 없는 하동훈은 출력되지 않을 것이다.
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.InchHeight}inch");
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////

            // 외부 조인 사용
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps
                               from d2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음" }) // Null이면 "작품없음" 출력
                               select new
                               {
                                   Name = p.Name,
                                   Work = d2.Title,
                                   InchHeight = p.Height * 0.393,
                               };

            Console.WriteLine("외부조인 결과!");
            
            // 외부조인과 같은 원리로, 작품이 없는 하동훈도 같이 출력된다.
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.InchHeight}inch");
            }
            Console.WriteLine();

        }
    }
}
