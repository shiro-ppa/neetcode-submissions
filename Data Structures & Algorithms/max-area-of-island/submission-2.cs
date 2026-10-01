public class Solution {

    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[0].Length; col++) {
                max = Math.Max(max, Dfs(grid,row,col));
            }
        }
        return max;
    }
    private int Dfs(int[][] grid, int r, int c) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) return 0;
        if (grid[r][c] != 1) return 0;

        grid[r][c] = 0;
        return 1 + Dfs(grid, r+1, c) + Dfs(grid, r-1, c) + Dfs(grid, r, c+1) + Dfs(grid, r, c-1);
    }
}
