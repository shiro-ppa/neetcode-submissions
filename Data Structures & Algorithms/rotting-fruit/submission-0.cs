public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
        int minutes = 0;
        int fresh = 0;
        for (int r = 0; r < grid.Length; r++) {
            for (int c = 0; c < grid[0].Length; c++) {
                if (grid[r][c] == 1) fresh++;
                else if (grid[r][c] == 2) {
                    queue.Enqueue((r,c));
                }
            }
        }
        while (queue.Count > 0 && fresh > 0) {
            int size = queue.Count;
            // array of directions to skip calling 4 times
            int[][] dirs = { new[]{1,0}, new[]{-1,0}, new[]{0,1}, new[]{0,-1} };
            for (int i = 0; i < size; i++) {
                var (r, c) = queue.Dequeue();
                foreach (var d in dirs) {
                    int nr = r + d[0]; // going up/down
                    int nc = c + d[1]; // going left/right
                    if (nr < 0 || nr >= grid.Length || nc < 0 || nc >= grid[0].Length) continue;
                    if (grid[nr][nc] != 1) continue;
                    else {
                        grid[nr][nc] = 2;
                        fresh--;
                        queue.Enqueue((nr, nc));
                    }
                }
            }

            minutes++;
        }
        return fresh > 0 ? -1 : minutes; // (if) condition ? valueIfTrue : valueIfFalse;
    }
}
