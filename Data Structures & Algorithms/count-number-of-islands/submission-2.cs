public class Solution {
    public int NumIslands(char[][] grid) {
        int count = 0;

        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[0].Length; col++) {
                if (grid[row][col] == '1') {
                    Dfs(grid, row, col);
                    count++;
                }
            }
        }

        return count;
    }
    private void Dfs(char[][] grid, int r, int c) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) return;
        if (grid[r][c] != '1') return;

        grid[r][c] = '0';

        Dfs(grid, r+1, c);
        Dfs(grid, r-1, c);
        Dfs(grid, r, c+1);
        Dfs(grid, r, c-1);
    }
}
