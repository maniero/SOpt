public static int BinarySearch(int[]! a, int key)
    requires forall{int i in (0: a.Length), int j in (i: a.Length); a[i] <= a[j]};
    ensures 0 <= result ==> a[result] == key;
    ensures result < 0 ==> forall{int i in (0: a.Length); a[i] != key};
 {
     int low = 0;
     int high = a.Length - 1;
     while (low <= high)
         invariant high+1 <= a.Length;
         invariant forall{int i in (0: low); a[i] != key};
         invariant forall{int i in (high+1: a.Length); a[i] != key};
     {
         int mid = (low + high) / 2;
         int midVal = a[mid];
         if (midVal < key) {
             low = mid + 1;
         } else if (key < midVal) {
             high = mid - 1;
         } else {
             return mid; // key found
         }
    }
    return -(low + 1);  // key not found.
}

//https://pt.stackoverflow.com/q/210606/101
