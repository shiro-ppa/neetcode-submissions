public class Solution {
    public void Solve(char[][] board) {
        var queue = new Queue<(int r, int c)>();
        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[0].Length; c++) {
                if (r > 0 && r < board.Length - 1 && c > 0 && c < board[0].Length - 1) continue;
                else if (board[r][c] == 'O') {
                    board[r][c] = 'S';
                    queue.Enqueue((r,c));
                }
            }
        }
        while (queue.Count > 0) {
            int size = queue.Count;
            int[][] dirs = { new[]{1,0},new[]{-1,0},new[]{0,1},new[]{0,-1} };
            for (int i = 0; i < size; i++) {
                var (r, c) = queue.Dequeue();
                foreach (int[] d in dirs) {
                    int nr = r + d[0];
                    int nc = c + d[1];
                    if (nr < 0 || nr >= board.Length || nc < 0 || nc >= board[0].Length) continue;
                    if (board[nr][nc] != 'O') continue;
                    else {
                        board[nr][nc] = 'S';
                        queue.Enqueue((nr,nc));
                    }
                }
            }
        }
        for (int r = 0; r < board.Length; r++) {
            for (int c = 0; c < board[0].Length; c++) {       
                if (board[r][c] == 'O') board[r][c] = 'X';
                else if (board[r][c] == 'S') board[r][c] = 'O';
                else continue;
            }
        }  
    }
}
