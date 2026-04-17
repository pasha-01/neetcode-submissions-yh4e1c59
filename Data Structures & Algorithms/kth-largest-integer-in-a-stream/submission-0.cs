public class KthLargest {
    private PriorityQueue<int, int> minHeap;
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums) {
            Add(num); // reuse logic
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);

        if (minHeap.Count > k) {
            minHeap.Dequeue(); // remove smallest
        }

        return minHeap.Peek(); // kth largest
    }
}