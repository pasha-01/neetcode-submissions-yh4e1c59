public class Solution {
    public bool IsValid(string s) {
        char[] stack = new char[s.Length];
        int top = 0;
        for(int i=0; i<s.Length; i++){
            char ch = s[i];
            if(ch == '(' || ch =='{' || ch=='['){
                stack[top] = ch;
                top++;
            }
            else{
                if(top==0)
                return false;
                top--;
                char last = stack[top];
                if(ch==')' && last!= '(') return false;
                if(ch=='}' && last!= '{') return false;
                if(ch==']' && last!= '[') return false;
            }
        }
        return top == 0;
    }
}
