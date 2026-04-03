public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int min = prices[0];
        // for ( int i = 0 ; i< prices.Length ; i ++){
        //      if ( prices[ i] < min){
        //         min = prices[ i];
        //      }
        //      profit = Math.Max(profit , prices[i]- min)
        // }
        foreach( int sell in prices){
            profit = Math.Max( profit , sell - min);
            min = Math. Min( min , sell);
        }
        return profit;
        
    }
}
