//요소 연산자 Element Operators  
//      First, FirstOrDefault, ElementAt
//      요소 연산자는 LINQ 구문 결과에서 원하는 위치의 요소 하나를 선택할 때 사용하는 연산자입니다.
//      정렬 연산자 orderby 와 같이 사용하는 경우가 많습니다.

using System;
using System.Collections.Generic;
using System.Linq;

class MainApp
{
    static void Main(string[] args)
    {
        //First
        //  주어진 조건으로 검색된 첫 번째 요소 찾기

        List<Product> products = GetProductList();

        Product product12 = (from p in products where p.ProductID == 12
                             select p)
                             .First();
        //products 리스트에서 ProductID가 12인 요소 중 첫 번째로 검색된 요소가 product12 변수에 할당됩니다.

        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string startsWithO = strings.First(s => s[0] == 'o');
        // startsWith0 = "one";

        //strings 배열에서 알파벳 'o'로 시작하는 단어 중 첫 번째로 검색된 단어 "one" 이 startsWithO 에 할당됩니다.


        //FirstOrDefault
        //  주어진 조건에 맞는 첫 번째 요소가 없을 경우 디폴트 값 받기
        //  만약 입력 시퀀스가 비어 있거나 조건에 맞는 값이 없을 경우, 디폴트 값을 반환합니다.

        int[] numbers = { };
        int firstNumOrDefault = numbers.FirstOrDefault();
        // numbers 배열이 비어 있으므로 int의 디폴트 값인 0 을 할당합니다.
        // firstNumOrDefault = 0;
            
        List<Product> products = GetProductList();
        Product product789 = products.FirstOrDefault(p => p.ProductID == 789);
        // 만약 products 리스트에 ProductID 속성이 789인 요소가 있을 경우, 해당 요소를 반환합니다.
        //없을 경우, Product 기본 생성자로 생성된 객체를 반환합니다.


        //ElementAt
        //  특정 위치에 있는 요소 찾기

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        int fourthLowNum = (
            from n in numbers
            where n > 5
            select n)
            .ElementAt(1);

        // numbers 배열 중 5 보다 큰 배열은 { 9, 8, 6, 7 }
        // 그중 [1]에 위치한 값은 8 이므로,
        // fourthLowNum =  8;

    } 
} 
