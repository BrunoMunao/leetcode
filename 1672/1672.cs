int MaximumWealth(int[][] accounts)
{
    int maxWealth = 0;
    int totalMoney = 0;

    for (int i = 0; i < accounts.Length; i++)
    {
        totalMoney = 0;
        for (int j = 0; j < accounts[i].Length; j++)
        {
            totalMoney += accounts[i][j];
            
        }
        if (totalMoney > maxWealth)
            maxWealth = totalMoney;
    }
    return maxWealth;
}

int[][] accounts = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {3, 2, 1}
};
Console.WriteLine(MaximumWealth(accounts)); 