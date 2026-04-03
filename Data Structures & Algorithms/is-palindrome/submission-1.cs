// public class Solution {
//     public bool IsPalindrome(string s) {
//         int left=0;
//         int right = s.Length -1;
//         while(left<right){
//             if(s[left] != s[right]){
//                 return false;
//             }
//             left++;
//             right--;
//         }
//         return true;
//     }
// }

// public class Solution {
//     public bool IsPalindrome(string s) {
//         int left= 0;
//         int right = s.Length-1;
//         while(left<right){
//             while(left<right && !Character.isLetterOrDigit(s.charAt(left))){
//                 left++;
//             }
//             while(left<right && !Character.isLetterOrDigit(s.charAt(right))){
//                 right--;
//             }
//             if(Character.toLowerCase(s.charAt(left))!=Character.toLowerCase(s.charAt(right))){
//                 return false;
//             }
//             left++;
//             right--;
//         }
//         return true;
//     }
// }


public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length -1;
        while (left< right ){
            while( left < right && !AlphaNum(s[left])){
                left ++;
            }
            while (right > left && !AlphaNum(s[right])){
                right --;
            }
            if ( char.ToLower(s[left])!= char.ToLower(s[right])){
                return false;
            }
            left ++;
            right --;
        }
        return true;
    }
     public bool AlphaNum(char c){
            return (c >= 'A' && c<= 'Z' ||
                    c>= 'a' && c<= 'z' ||
                    c>='0' & c<= '9');
        }
}

