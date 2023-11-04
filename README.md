# Codility-Flags
A non-empty array A consisting of N integers is given.</br>
A peak is an array element which is larger than its neighbors.</br>
More precisely, it is an index P such that 0 < P < N − 1 and A[P − 1] < A[P] > A[P + 1].

For example, the following array A:</br>
A[0]  = 1</br>
A[1]  = 5</br>
A[2]  = 3</br>
A[3]  = 4</br>
A[4]  = 3</br>
A[5]  = 4</br>
A[6]  = 1</br>
A[7]  = 2</br>
A[8]  = 3</br>
A[9]  = 4</br>
A[10] = 6</br>
A[11] = 2</br>
has exactly four peaks: elements 1, 3, 5, and 10.</br>
You are going on a trip to a range of mountains whose relative heights are represented by array A,</br> 
as shown in the figure below.</br> 
You have to choose how many flags you should take with you.</br> 
The goal is to set the maximum number of flags on the peaks, according to certain rules.

Flags can only be set on peaks.</br> 
What's more, if you take K flags,</br> 
then the distance between any two flags should be greater than or equal to K.</br> 
The distance between indices P and Q is the absolute value |P − Q|.

For example, given the mountain range represented by array A, above, with N = 12, if you take:</br>
two flags, you can set them on peaks 1 and 5;</br>
three flags, you can set them on peaks 1, 5, and 10;</br>
four flags, you can set only three flags, on peaks 1, 5, and 10.</br>
You can therefore set a maximum of three flags in this case.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A of N integers,</br> 
returns the maximum number of flags that can be set on the peaks of the array.

For example, the following array A:</br>
A[0]  = 1</br>
A[1]  = 5</br>
A[2]  = 3</br>
A[3]  = 4</br>
A[4]  = 3</br>
A[5]  = 4</br>
A[6]  = 1</br>
A[7]  = 2</br>
A[8]  = 3</br>
A[9]  = 4</br>
A[10] = 6</br>
A[11] = 2</br>
the function should return 3, as explained above.</br>

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..400,000];</br>
each element of array A is an integer within the range [0..1,000,000,000].
