public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9]; 
        HashSet<char>[] cols = new HashSet<char>[9]; 
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < board.Length; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int row = 0; row < board.Length; row++) {
            for (int col = 0; col < board[0].Length; col++) {
                char c = board[row][col];
                if (c == '.') continue;
                
                int boxIndex = (row / 3) * 3 + (col / 3);

                if (!rows[row].Add(c) || !cols[col].Add(c) || !boxes[boxIndex].Add(c)) return false;
            }
        } 
        return true;
    }
}
