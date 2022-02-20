using System;
namespace Mutlak_Kare_alma{
    public static class MainClass{
        static void Main(string[] args){
            List<int> input_list = Console_processor.input();

            List<int> result_list = new List<int>(){0,0};
            for (int i = 0;i< input_list.Count ; i++)
            {
                int result = 0;
                    if(input_list[i] < 67){
                        result =67 - input_list[i];
                        result_list[0] += result;
                    }
                    else {
                        result = (input_list[i] -67) * (input_list[i] -67);
                        result_list[1] += result;
                    }
            }
            Console.WriteLine("______Sonuç____ ↓");
            foreach (var item in result_list)
            {
                Console.Write(item + " ");
            }
        }
    }
}