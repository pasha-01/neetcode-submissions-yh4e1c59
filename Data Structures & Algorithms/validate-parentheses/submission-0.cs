public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> mappedBrackets = new Dictionary<char , char>{
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        Stack<char> stack = new Stack<char>();
        foreach( char c in s){
            if(mappedBrackets.ContainsKey(c)){
                if(stack.Count >0 && stack.Peek()== mappedBrackets[c]){
                    stack.Pop();
                }
                else{
                    return false;
                }
            } 
            else{
                    stack.Push(c);
                }
        }
        return stack.Count == 0;
        
    }
}
