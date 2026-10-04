public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        var queue = new Queue<(int r, int c)>();
        const int inf = int.MaxValue;
        int[][] dirs = { new[]{1,0},new[]{-1,0},new[]{0,1},new[]{0,-1} };
        for (int r = 0; r < grid.Length; r++) {
            for (int c = 0; c < grid[0].Length; c++) {
                if (grid[r][c] == 0) queue.Enqueue((r,c));
                else continue; 
            }
        }
        int level = 1;
        while (queue.Count > 0) {
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                var (r,c) = queue.Dequeue();
                foreach (int[] d in dirs) {
                    int nr = r + d[0];
                    int nc = c + d[1];
                    if (nr < 0 || nr >= grid.Length || nc < 0 || nc >= grid[0].Length) continue;
                    if (grid[nr][nc] != inf) continue;
                    else {
                        grid[nr][nc] = level;
                        queue.Enqueue((nr,nc));
                    }
                }
            }
            level++;
        }
    }
}
