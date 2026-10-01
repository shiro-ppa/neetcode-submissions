public class Solution {
    int count = 0;
    int max = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[0].Length; col++) {
                if (grid[row][col] == 1) {
                    Dfs(grid, row, col);
                    max = Math.Max(max, count);
                    count = 0;
                }
            }
        }
        return max;
    }
    private void Dfs(int[][] grid, int r, int c) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) return;
        if (grid[r][c] != 1) return;

        grid[r][c] = 0;
        count++;

        Dfs(grid, r+1, c);
        Dfs(grid, r-1, c);
        Dfs(grid, r, c+1);
        Dfs(grid, r, c-1);
    }
}
