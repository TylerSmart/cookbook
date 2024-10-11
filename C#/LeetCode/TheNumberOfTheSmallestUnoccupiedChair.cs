namespace LeetCode.TheNumberOfTheSmallestUnoccupiedChair
{
    public static class Solution
    {
        public static int Solve(int[][] times, int targetFriend)
        {
            int NUMBER_OF_FRIENDS = times.Length;

            PriorityQueue<int, (int Time, bool IsArrival)> queue = new (
                Comparer<(int Time, bool IsArrival)>.Create((a, b) => {
                    int timeComparison = a.Time.CompareTo(b.Time);
                    if (timeComparison != 0) return timeComparison;
                    return a.IsArrival.CompareTo(b.IsArrival);
                }));
            
            Dictionary<int, int> takenChairs = new();
            Dictionary<int, int> arrivedFriends = new();
            
            int smallestUnoccupiedChair = 0;
            
            for (int i = 0; i < NUMBER_OF_FRIENDS; i++)
            {
                queue.Enqueue(i, (times[i][0], true));
                queue.Enqueue(i, (times[i][1], false));
            }


            for (int friend = queue.Dequeue(); queue.Count > 0; friend = queue.Dequeue())
            {
                if (arrivedFriends.ContainsKey(friend))
                {
                    // departing
                    int chair = arrivedFriends[friend];
                    if (smallestUnoccupiedChair > chair) smallestUnoccupiedChair = chair;
                    takenChairs.Remove(chair);
                    arrivedFriends.Remove(friend);
                }
                else
                {
                    // arriving
                    if (friend == targetFriend) break;

                    int chair = smallestUnoccupiedChair;
                    arrivedFriends.Add(friend, chair);
                    takenChairs.Add(chair, friend);

                    // find new smallest Unoccupied chair
                    for (int i = smallestUnoccupiedChair + 1; i < NUMBER_OF_FRIENDS; i++)
                    {
                        if (takenChairs.ContainsKey(i) == false)
                        {
                            smallestUnoccupiedChair = i;

                            break;
                        }
                    }
                }
            }

            return smallestUnoccupiedChair;
        }
    }
}
