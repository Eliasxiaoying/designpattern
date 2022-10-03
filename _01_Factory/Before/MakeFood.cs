namespace _01_FactoryPattern.Before
{
    public class MakeFood
    {
        public static void Make()
        {
            // 需要客户端判断自己需要的类型， 逻辑分散在各处 不易于修改 极大违反了OC原则 （Open-Close）
            IFood food1 = new ShreddedPorkWithPotatoes();
            food1.Print();

            IFood food2 = new TomatoScrambledEggs();
            food2.Print();
        }
    }
}