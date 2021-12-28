public static class GameData
{
    static private int balance = 30;

    static public void DecreaseBalanceByValue(int value)
    {
        if (balance <= 1)
            balance = 30;
        else
            balance -= value;
    }

    static public int GetBalance()
    {
        return balance;
    }
}
